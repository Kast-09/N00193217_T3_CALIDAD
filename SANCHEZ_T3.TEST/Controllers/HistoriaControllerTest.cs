using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SANCHEZ_T3.WEB.Controllers;
using SANCHEZ_T3.WEB.Repositorios;
using SANCHEZ_T3.WEB.Models;
using NUnit.Framework;

namespace SANCHEZ_T3.TEST.Controllers
{
    public class HistoriaControllerTest
    {
        [Test]
        public void ListarViewCase()
        {
            var mockHistoriaClinica = new Mock<IHistoriaClinicaRepositorio>();

            var listarT = new HistoriaClinicaController(null, null, mockHistoriaClinica.Object, null);
            var view = (ViewResult)listarT.Listar();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }

        [Test]
        public void CrearGetViewCase()
        {
            var crearT = new HistoriaClinicaController(null, null, null, null);
            var view = (ViewResult)crearT.Crear();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }

        [Test]
        public void CrearPostViewCase()
        {
            var mockMascota = new Mock<IMascotaRepositorio>();

            var crearT = new HistoriaClinicaController(null, null, null, mockMascota.Object);
            var view = (ViewResult)crearT.Crear();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void CrearMascotaGetViewCase()
        {
            var crearMascotaT = new HistoriaClinicaController(null, null, null, null);
            var view = (ViewResult)crearMascotaT.CrearMascota();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }

        [Test]
        public void CrearMascotaPostViewCase()
        {
            var mockMascota = new Mock<IMascotaRepositorio>();
            var mockDueño = new Mock<IDueñoRepositorio>();
            mockDueño.Setup(o => o.listarDueños()).Returns(new List<Dueño>());

            var crearT = new HistoriaClinicaController(null, mockDueño.Object, null, mockMascota.Object);
            var view = (ViewResult)crearT.CrearMascota(new Mascota() { Id = 10, Especie = "Perro" });

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void CrearHistoriaGetViewCase()
        {
            var crearHistoriaT = new HistoriaClinicaController(null, null, null, null);
            var view = (ViewResult)crearHistoriaT.CrearHistoria();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }

        [Test]
        public void CrearHistoriaPostViewCase()
        {
            var mockMascota = new Mock<IMascotaRepositorio>();
            var mockHistoria = new Mock<IHistoriaClinicaRepositorio>();

            var crearHistoriaT = new HistoriaClinicaController(null, null, mockHistoria.Object, mockMascota.Object);
            var view = (ViewResult)crearHistoriaT.CrearHistoria(new HistoriaClinica());

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
