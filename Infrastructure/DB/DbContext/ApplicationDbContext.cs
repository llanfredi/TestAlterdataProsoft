using Domain.Entities;
using Domain.Entities.Base;
using Infrastructure.Mappings;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using System.Security.Claims;

namespace Infrastructure.DB
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DbSet<TipoDevEntity> TipoDev { get; set; }
        public DbSet<DevEntity> Dev { get; set; }
        public DbSet<AuthEntity> Auth { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("DBCadDev");
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TipoDevMapping());
            modelBuilder.ApplyConfiguration(new DevMapping());
            modelBuilder.ApplyConfiguration(new AuthMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public override int SaveChanges()
        {
            CheckEntities(ChangeTracker.Entries());

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken) 
        {
            CheckEntities(ChangeTracker.Entries());
            
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void CheckEntities(IEnumerable<EntityEntry> entries) 
        {
            var currentDate = DateTime.Now;

            foreach (var entry in entries.Where(e => e.Entity is NonEditableEntity)) 
            {
                if (entry.State == EntityState.Added)
                    SetCreateValues(currentDate, entry);

                if (entry.State == EntityState.Modified && entry.Entity is EditableEntity)
                    SetUpdateValues(currentDate, entry);
            }
        }

        private void SetCreateValues(DateTime currentDate, EntityEntry entry) 
        {
            if (entry.Property("CreatedDate") != null)
                entry.Property("CreatedDate").CurrentValue = currentDate;

            if (entry.Property("CreatedBy") != null)
                entry.Property("CreatedBy").CurrentValue = GetCurrentUser();
        }

        private void SetUpdateValues(DateTime currentDate, EntityEntry entry) 
        {
            entry.Property("CreatedDate").IsModified = false;
            entry.Property("CreatedBy").IsModified = false;

            if(entry.Property("UpdatedDate") != null)
                entry.Property("UpdatedDate").CurrentValue = currentDate;

            if (entry.Property("UpdatedBy") != null)
                entry.Property("UpdatedBy").CurrentValue = GetCurrentUser();
        }

        private string GetCurrentUser() 
        {
            return _httpContextAccessor.HttpContext?.User?.Identity?.Name?.ToString() ?? Guid.NewGuid().ToString();
        }
    }
}
