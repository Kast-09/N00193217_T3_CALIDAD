using SANCHEZ_T3.WEB.DB;
using SANCHEZ_T3.WEB.Models;

namespace SANCHEZ_T3.WEB.Repositorios
{
    public interface IDueñoRepositorio
    {
        void guardarDueños(Dueño dueño);
        List<Dueño> listarDueños();
    }
    public class DueñoRepositorio: IDueñoRepositorio
    {
        private DbEntities _DbEntities;

        public DueñoRepositorio(DbEntities dbEntities)
        {
            _DbEntities = dbEntities;
        }
        public void guardarDueños(Dueño dueño)
        {
            _DbEntities.dueños.Add(dueño);
            _DbEntities.SaveChanges();
        }
        public List<Dueño> listarDueños()
        {
            return _DbEntities.dueños.ToList();
        }
    }
}
