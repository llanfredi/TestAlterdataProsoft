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
        }
    }
}
