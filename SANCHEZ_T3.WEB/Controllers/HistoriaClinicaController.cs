using Microsoft.AspNetCore.Mvc;
using SANCHEZ_T3.WEB.Models;
using SANCHEZ_T3.WEB.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using SANCHEZ_T3.WEB.Repositorios;

namespace SANCHEZ_T3.WEB.Controllers
{
    [Authorize]
    public class HistoriaClinicaController : Controller
    {
        private DbEntities _DbEntities;
        private readonly IDueñoRepositorio _dueñoRepositorio;
        private readonly IHistoriaClinicaRepositorio _historiaClinicaRepositorio;
        private readonly IMascotaRepositorio _mascotaRepositorio;

        public HistoriaClinicaController(DbEntities dbEntities, IDueñoRepositorio dueñoRepositorio, IHistoriaClinicaRepositorio historiaClinicaRepositorio, IMascotaRepositorio mascotaRepositorio)
        {
            _DbEntities = dbEntities;
            _dueñoRepositorio = dueñoRepositorio;
            _historiaClinicaRepositorio = historiaClinicaRepositorio;
            _mascotaRepositorio = mascotaRepositorio;
        }
        public IActionResult Listar()
        {
            var item = _historiaClinicaRepositorio.obtenerHistorias();
            return View(item);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(Dueño dueño)
        {
            _dueñoRepositorio.guardarDueños(dueño);
            return RedirectToAction("CrearMascota", "HistoriaClinica");
        }
        [HttpGet]
        public IActionResult CrearMascota()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearMascota(Mascota mascota)
        {
            var dueños = _dueñoRepositorio.listarDueños();
            foreach (var item in dueños)
            {
                mascota.IdDueño = item.Id;
            }
            _mascotaRepositorio.agregarMascota(mascota);
            return RedirectToAction("CrearHistoria", "HistoriaClinica");
        }
        [HttpGet]
        public IActionResult CrearHistoria()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearHistoria(HistoriaClinica historiaClinica)
        {
            var mascotas = _mascotaRepositorio.listarMascotas();
            foreach (var item in mascotas)
            {
                historiaClinica.IdMascota = item.Id;
            }
            _historiaClinicaRepositorio.guardarHistoriaClinica(historiaClinica);
            return RedirectToAction("Listar", "HistoriaClinica");
        }
    }
}
