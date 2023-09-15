using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappings
{
    public class TipoDevMapping : BaseMapping<TipoDevEntity>
    {
        public TipoDevMapping() : base("TipoDev")
        {
        }

        public override void Configure(EntityTypeBuilder<TipoDevEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DescTipoDev).IsRequired();

            builder.HasData(new TipoDevEntity 
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Estágiário",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });

            builder.HasData(new TipoDevEntity
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Estágiário",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });

            builder.HasData(new TipoDevEntity
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Júnior",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });

            builder.HasData(new TipoDevEntity
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Pleno",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });

            builder.HasData(new TipoDevEntity
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Sênior",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });

            builder.HasData(new TipoDevEntity
            {
                Id = Guid.NewGuid(),
                DescTipoDev = "Especialista",
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                Active = true,
            });
        }
    }
}
