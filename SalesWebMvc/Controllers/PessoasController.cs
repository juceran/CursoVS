using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            var salesWebMvcContext = _context.Pessoa
                                        .Include(p => p.PessoaCliente)
                                        .Include(p => p.PessoaFisica)
                                        .Include(p => p.PessoaFornecedor)
                                        .Include(p => p.PessoaJuridica)
                                        .Include(p => p.PessoaUsuario);
            return View(await salesWebMvcContext.ToListAsync());
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa
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
            var pessoa = new Pessoa
            {
                EmpresaId = 1,
                DataCadastro = DateTime.Now,
                UltimaAtualizacao = DateTime.Now,
                Ativo = true,
                PessoaCliente = new PessoaCliente(),
                PessoaFornecedor = new PessoaFornecedor(),
                PessoaUsuario = new PessoaUsuario(),
                PessoaFisica = new PessoaFisica()                
            };

            return View(pessoa);
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpresaId,Descricao,DataCadastro,Ativo,UltimaAtualizacao,Deletado,DeletadoData," +
            "PessoaCliente,PessoaFornecedor,PessoaFisica")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                if (pessoa.PessoaCliente.Cliente == true)
                {
                    pessoa.PessoaCliente.Ativo = true;
                    pessoa.PessoaCliente.DataCadastro = DateTime.Now;
                    pessoa.PessoaCliente.UltimaAtualizacao = DateTime.Now;
                }
                if (pessoa.PessoaFornecedor.Fornecedor == true)
                {
                    pessoa.PessoaFornecedor.Ativo = true;
                    pessoa.PessoaFornecedor.DataCadastro = DateTime.Now;
                    pessoa.PessoaFornecedor.UltimaAtualizacao = DateTime.Now;
                }
                if(pessoa.PessoaFisica != null)
                {

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

            var pessoa = await _context.Pessoa.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.PessoaCliente, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaFisica, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaFornecedor, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaJuridica, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaUsuario, "Id", "Id", pessoa.Id);
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
            ViewData["Id"] = new SelectList(_context.PessoaCliente, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaFisica, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaFornecedor, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaJuridica, "Id", "Id", pessoa.Id);
            ViewData["Id"] = new SelectList(_context.PessoaUsuario, "Id", "Id", pessoa.Id);
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = await _context.Pessoa
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
            var pessoa = await _context.Pessoa.FindAsync(id);
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
