﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SANCHEZ_T3.WEB.DB;
using SANCHEZ_T3.WEB.Models;

namespace SANCHEZ_T3.WEB.Controllers
{
    public class AuthController : Controller
    {
        private DbEntities _dbEntities;

        public AuthController(DbEntities dbEntities)
        {
            _dbEntities = dbEntities;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // si el usuario existe en la base de datos generar la cookie, caso contrario mostrar mensaje de usaurio o password erroneo

            if (_dbEntities.usuarios.Any(x => x.Username == username && x.Password == password))
            {
                var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, username),
            };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("AuthError", "Usuario y/o contraseña erronea");
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}