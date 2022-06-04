using Microsoft.EntityFrameworkCore;
using SANCHEZ_T3.WEB.DB;
using SANCHEZ_T3.WEB.Models;

namespace SANCHEZ_T3.WEB.Repositorios
{
    public interface IHistoriaClinicaRepositorio
    {
        List<HistoriaClinica> obtenerHistorias();
        void guardarHistoriaClinica(HistoriaClinica historiaClinica);
    }
    public class HistoriaClinicaRepositorio : IHistoriaClinicaRepositorio
    {
        private DbEntities _DbEntities;

        public HistoriaClinicaRepositorio(DbEntities dbEntities)
        {
            _DbEntities = dbEntities;
        }

        public List<HistoriaClinica> obtenerHistorias()
        {
            return _DbEntities.historiaClinicas
                .Include(o => o.mascota)
                .Include(o => o.mascota.dueño)
                .ToList();
        }

        public void guardarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            _DbEntities.historiaClinicas.Add(historiaClinica);
            _DbEntities.SaveChanges();
        }
    }
}
