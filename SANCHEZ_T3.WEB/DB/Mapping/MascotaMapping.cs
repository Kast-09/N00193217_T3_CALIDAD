using SANCHEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SANCHEZ_T3.WEB.DB.Mapping
{
    public class MascotaMapping : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> builder)
        {
            builder.ToTable("Mascota", "dbo");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.dueño)
                .WithMany()
                .HasForeignKey(o => o.IdDueño);
        }
    }
}
