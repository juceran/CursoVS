using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Controllers
{
    public class LoginsController : Controller
    {
        private readonly ComumContext _context;
        private readonly SalesWebMvcContext _contextAplicacao;
        
        public LoginsController(ComumContext context, SalesWebMvcContext contextAplicacao)
        {
            _context = context;
            _contextAplicacao = contextAplicacao;
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
                //Remover caracteres do CPForCNPJ
                CNPJ = RemoverCaracteres.StringSemFormatacao(login.CNPJ);

                //testar se a empresa existe e qual o banco de dados
                IQueryable<Empresa> empresaComum = _context.Empresa
                    .Where(e => e.CNPJ == CNPJ)
                    .Where(e => e.Ativo == true);
                string database = "";
                foreach (Empresa p in empresaComum)
                {
                    database = p.Database;
                }
                if (database != "")
                {
                    Program.BancoDeDadosAplicacao = database;
                    if (Program.BancoDeDadosAplicacao != null)
                    {

                    }
                    //verifica o acesso do usuario na base da aplicacao
                    IQueryable<Empresa> empresaAplicacao = _contextAplicacao.Empresa
                        .Where(e => e.CNPJ == CNPJ)
                        .Where(e => e.Database == database)
                        .Where(x => x.Ativo == true);
                    foreach (Empresa item in empresaAplicacao)
                    {
                        Program.UserEmpresaId = item.Id;
                    }

                    bool loginOk = login.ValidarLogin();
                }
                else
                {
                    return RedirectToAction("Index", "Departamentos");
                }



                return RedirectToAction("Index", "Pessoas");
            }
            else
            {
                return RedirectToAction("Index", "Departamentos");
            }

        }
    }
}