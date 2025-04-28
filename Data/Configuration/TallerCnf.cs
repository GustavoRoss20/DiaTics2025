using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    internal class TallerCnf : IEntityTypeConfiguration<TallerEtd>
    {
        public void Configure(EntityTypeBuilder<TallerEtd> builder)
        {
            builder.ToTable("Taller");

            //Id tinyint	1	no
            builder.HasKey(t => t.Id);

            //Nombre  varchar	100	no
            builder.Property(x => x.Nombre).IsUnicode(false);
        }
    }
}
