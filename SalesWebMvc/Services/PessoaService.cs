using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class PessoaService
    {
        private readonly SalesWebMvcContext _context;

        public PessoaService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public bool ValidarPessoaUsuario(Pessoa pessoa)
        {
            //valida USUARIO
            if (pessoa.PessoaUsuario.User == true)
            {
                IQueryable<Pessoa> x = _context.Pessoa
                    .Where(p => p.EmpresaId == pessoa.EmpresaId)
                    .Where(p => p.PessoaUsuario.Usuario == pessoa.PessoaUsuario.Usuario && p.PessoaUsuario.Ativo == true);
                if(x.GetEnumerator().MoveNext() == true)
                {
                    return true;
                }
            }


            return false;
        }
    }
}