using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using SANCHEZ_T3.WEB.Controllers;
using SANCHEZ_T3.WEB.Repositorios;
using NUnit.Framework;

namespace SANCHEZ_T3.TEST.Controllers
{
    public class HomeControllerTest
    {
        [Test]
        public void indexViewCase()
        {
            var indexT = new HomeController();
            var view = (ViewResult)indexT.Index();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void privacyViewCase()
        {
            var privacyT = new HomeController();
            var view = (ViewResult)privacyT.Index();

            Assert.IsNotNull(view);
            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
