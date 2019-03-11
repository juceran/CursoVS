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
                //var dptoExiste = _departamentoService.DepartamentoExiste(departamento);
                if (_loginService.ValidarAcesso(login))
                {
                    return RedirectToAction("Index", "Pessoas");
                }
                else
                {
                    TempData["acesso"] = "Acesso não permitido!";
                    return RedirectToAction("Login");
                }              
            }
            else
            {
                return RedirectToAction("Index", "Departamentos");
            }

        }
    }
}