using SANCHEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SANCHEZ_T3.WEB.DB.Mapping
{
    public class HistoriaClinicaMapping : IEntityTypeConfiguration<HistoriaClinica>
    {
        public void Configure(EntityTypeBuilder<HistoriaClinica> builder)
        {
            builder.ToTable("HistoriaClinica", "dbo");
            builder.HasKey(o => o.CodRegistro);

            builder.HasOne(o => o.mascota)
                .WithMany()
                .HasForeignKey(o => o.IdMascota);
        }
    }
}
