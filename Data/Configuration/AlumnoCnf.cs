using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Business.Configuration
{
    internal class AlumnoCnf : IEntityTypeConfiguration<AlumnoEtd>
    {
        public void Configure(EntityTypeBuilder<AlumnoEtd> builder)
        {
            builder.ToTable("Alumno");

            //NumeroControl varchar	10	no
            builder.HasKey(x => x.NumeroControl);
            builder.Property(x => x.NumeroControl).ValueGeneratedNever().IsUnicode(false);

            //Nombre  varchar	50	no
            builder.Property(x => x.Nombre).IsUnicode(false);

            //ApellidoPaterno varchar	50	no
            builder.Property(x => x.ApellidoPaterno).IsUnicode(false);

            //ApellidoMaterno varchar	50	no
            builder.Property(x => x.ApellidoMaterno).IsUnicode(false);

            //Carrera varchar	50	no
            builder.Property(x => x.Carrera).IsUnicode(false);

            //RegistradoParaEvento    bit	1	no
            builder.Property(x => x.RegistradoParaEvento);

            //FechaRegistro   datetime	8	yes
            builder.Property(x => x.FechaRegistro).IsRequired(false);
        }

    }
}
