using SANCHEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SANCHEZ_T3.WEB.DB.Mapping
{
    public class DueñoMapping : IEntityTypeConfiguration<Dueño>
    {
        public void Configure(EntityTypeBuilder<Dueño> builder)
        {
            builder.ToTable("Dueño", "dbo");
            builder.HasKey(o => o.Id);
        }
    }
}
