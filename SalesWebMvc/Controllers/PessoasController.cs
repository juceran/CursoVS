using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class PessoasController : Controller
    {
        private readonly SalesWebMvcContext _context;

        public PessoasController(SalesWebMvcContext context)
        {
            _context = context;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
            IQueryable<Pessoa> salesWebMvcContext = _context.Pessoa
                                        .Include(p => p.PessoaCliente)
                                        .Include(p => p.PessoaFisica)
                                        .Include(p => p.PessoaFornecedor)
                                        .Include(p => p.PessoaJuridica)
                                        .Include(p => p.PessoaUsuario)
                                        .OrderBy(p => p.Descricao)
                                        .Where(p => p.Deletado == false)
                                        .Where(p => p.EmpresaId == Program.UserEmpresaId);
            return View(await salesWebMvcContext.ToListAsync());
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa pessoa = await _context.Pessoa
                .Include(p => p.PessoaCliente)
                .Include(p => p.PessoaFisica)
                .Include(p => p.PessoaFornecedor)
                .Include(p => p.PessoaJuridica)
                .Include(p => p.PessoaUsuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoas/Create
        public IActionResult Create()
        {
            //somente enquanto não implementa a AUTENTICAÇÃO
            if (Program.UserEmpresaId < 1)
            {
                Program.UserEmpresaId = 1;
            }

            Pessoa pessoa = new Pessoa
            {
                EmpresaId = Program.UserEmpresaId,
                DataCadastro = DateTime.Now,
                UltimaAtualizacao = DateTime.Now,
                Ativo = true,
                PessoaCliente = new PessoaCliente
                {
                    LimiteCredito = 1355
                },
                PessoaFornecedor = new PessoaFornecedor(),
                PessoaFisica = new PessoaFisica(),
                PessoaJuridica = new PessoaJuridica(),
                PessoaUsuario = new PessoaUsuario()
            };

            return View(pessoa);
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpresaId,Descricao,DataCadastro,Ativo,UltimaAtualizacao,Deletado,DeletadoData," +
            "PessoaCliente,PessoaFornecedor,PessoaFisica,PessoaJuridica,PessoaUsuario")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                //TODOS ESSES COMANDOS VÃO PARA A MODEL
                if (pessoa.PessoaCliente.Cliente == true)
                {
                    pessoa.PessoaCliente.Ativo = true;
                }
                if (pessoa.PessoaFornecedor.Fornecedor == true)
                {
                    pessoa.PessoaFornecedor.Ativo = true;
                }
                if (pessoa.PessoaFisica != null)
                {
                    pessoa.PessoaFisica.CPF = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaFisica.CPF);
                }
                if (pessoa.PessoaJuridica != null)
                {
                    pessoa.PessoaJuridica.CNPJ = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaJuridica.CNPJ);
                }
                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pessoa pessoa = await _context.Pessoa
                          .Include(p => p.PessoaCliente)
                          .Include(p => p.PessoaFisica)
                          .Include(p => p.PessoaFornecedor)
                          .Include(p => p.PessoaJuridica)
                          .Include(p => p.PessoaUsuario)
                          .FirstOrDefaultAsync(m => m.Id == id);
            //var pessoa = await _context.Pessoa.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData,Descricao,EmpresaId," +
                                                            "PessoaCliente," +
                                                            "PessoaFornecedor," +
                                                            "PessoaFisica," +
                                                            "PessoaJuridica," +
                                                            "PessoaUsuario")] Pessoa pessoa)
        {
             if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    pessoa.UltimaAtualizacao = DateTime.Now;
                    //pessoa.PessoaCliente.UltimaAtualizacao = DateTime.Now;
                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa pessoa = await _context.Pessoa
                .Include(p => p.PessoaCliente)
                .Include(p => p.PessoaFisica)
                .Include(p => p.PessoaFornecedor)
                .Include(p => p.PessoaJuridica)
                .Include(p => p.PessoaUsuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Pessoa pessoa = await _context.Pessoa.FindAsync(id);
            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(int id)
        {
            return _context.Pessoa.Any(e => e.Id == id);
        }
    }
}
