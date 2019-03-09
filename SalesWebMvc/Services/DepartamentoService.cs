using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentoService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public bool DepartamentoExiste(Departamento departamento)
        {
            var dptos = _context.Departamento.Where(d => d.EmpresaId == departamento.EmpresaId).OrderBy(d => d.Nome);
            foreach (Departamento item in dptos)
            {
                if (item.Nome == departamento.Nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
