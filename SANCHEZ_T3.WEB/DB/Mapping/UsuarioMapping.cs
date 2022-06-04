using SANCHEZ_T3.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SANCHEZ_T3.WEB.DB.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuarios>
    {        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.ToTable("Usuarios", "dbo");
            builder.HasKey(o => o.Id);
        }
    }
}
