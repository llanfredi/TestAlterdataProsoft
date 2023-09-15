using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
