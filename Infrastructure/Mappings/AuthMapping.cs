using Domain.Entities;
using Infrastructure.Security;
using Infrastructure.Security.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Mappings
{
    public class AuthMapping : BaseMapping<AuthEntity>
    {
        public AuthMapping() : base("Auth")
        {
        }

        public override void Configure(EntityTypeBuilder<AuthEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Login).IsRequired();
            builder.Property(x => x.Senha).IsRequired();

            builder.HasData(new AuthEntity
            {
                Id = Guid.NewGuid(),
                Nome = "Leandro Lanfredi",
                Login = "llanfredi",
                Senha = Crypt.EncryptString("ab2d6871d5914518a8adfbe525ab51b5", "123456"),
                CreatedBy = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                Active = true
            }); ;
        }
    }
}
