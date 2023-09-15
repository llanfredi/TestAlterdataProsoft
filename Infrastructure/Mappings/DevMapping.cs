using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mappings
{
    public class DevMapping : BaseMapping<DevEntity>
    {
        public DevMapping() : base("Dev")
        {
        }

        public override void Configure(EntityTypeBuilder<DevEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.IdTipoDev).IsRequired();

            builder.HasOne(x => x.TipoDev).WithOne().HasForeignKey<DevEntity>(x => x.Id);
        }
    }
}
