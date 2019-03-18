using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Controllers
{
    public class LoginsController : Controller
    {
        private readonly ComumContext _context;
        private readonly SalesWebMvcContext _contextAplicacao;
        private readonly LoginService _loginService;

        public LoginsController(ComumContext context, SalesWebMvcContext contextAplicacao, LoginService loginService)
        {
            _context = context;
            _contextAplicacao = contextAplicacao;
            _loginService = loginService;
        }

        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Senha { get; set; }

        public IActionResult Login()
        {           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Acessar(Login login)
        {
            if (ModelState.IsValid)
            {
                if (_loginService.ValidarAcesso(login))
                {
                    HttpContext.Session.SetInt32("LogonEmpresaId", Program.EmpresaId);
                    HttpContext.Session.SetString("LogonUsuario", login.Usuario);

                    return RedirectToAction("Index", "Pessoas");
                }
                else
                {
                    ViewData["acesso"] = "Acesso não permitido!";
                    return View("Login");
                }              
            }
            else
            {
                return View("Login");
                //return RedirectToAction("Index", "Departamentos");
            }

        }
    }
}