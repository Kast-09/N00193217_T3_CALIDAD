using SANCHEZ_T3.WEB.Models;

namespace SANCHEZ_T3.WEB.Models
{
    public class HistoriaClinica
    {
        public int CodRegistro { get; set; }
        public int IdMascota { get; set; }
        public Mascota mascota { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
