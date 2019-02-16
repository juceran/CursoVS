using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using SalesWebMvc.Models;

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
                //Remover caracteres do CNPJ
                CNPJ = RemoverCaracteres.StringNova(login.CNPJ);

                //testar se a empresa existe e qual o banco de dados
                IQueryable<Empresa> empresa =  _context.Empresa
                    .Where(e => e.CNPJ == CNPJ)
                    .Where(e => e.Ativo == true);
                string database = "";
                foreach (Empresa p in empresa)
                {
                    database = p.Database;
                }
                if (database != "")
                {
                    Program.BancoDeDadosAplicacao = database;

                    //verifica o acesso do usuario na base da aplicacao
                    IQueryable<Departamento> departamento = _contextAplicacao.Departamento
                        .Include(e => e.Empresa)
                        .Where(e => e.Empresa.Database == database)
                        .Where(x => x.Ativo == true);

                    bool loginOk = login.ValidarLogin();
                }
                else
                {
                    return RedirectToAction("Index", "Departamentos");
                }



                return RedirectToAction("Index", "Empresas");
            }
            else
            {
                return RedirectToAction("Index", "Departamentos");
            }
                
        }
    }
}