using SANCHEZ_T3.WEB.DB;
using SANCHEZ_T3.WEB.Models;

namespace SANCHEZ_T3.WEB.Repositorios
{
    public interface IMascotaRepositorio
    {
        void agregarMascota(Mascota mascota);
        List<Mascota> listarMascotas();
    }
    public class MascotaRepositorio : IMascotaRepositorio
    {
        private DbEntities _DbEntities;

        public MascotaRepositorio(DbEntities dbEntities)
        {
            _DbEntities = dbEntities;
        }

        public void agregarMascota(Mascota mascota)
        {
            _DbEntities.mascotas.Add(mascota);
            _DbEntities.SaveChanges();
        }

        public List<Mascota> listarMascotas()
        {
            return _DbEntities.mascotas.ToList();
        }
    }
}
