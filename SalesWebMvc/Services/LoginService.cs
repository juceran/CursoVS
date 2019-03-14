using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class LoginService
    {
        private readonly ComumContext _context;
        private readonly SalesWebMvcContext _contextAplicacao;

        public LoginService(ComumContext context, SalesWebMvcContext contextAplicacao)
        {
            _context = context;
            _contextAplicacao = contextAplicacao;
        }

        public bool ValidarAcesso(Login login)
        {
            //Remover caracteres do CPForCNPJ
            string CNPJ = RemoverCaracteres.StringSemFormatacao(login.CNPJ);

            //testar se a empresa existe e qual o banco de dados
            IQueryable<Empresa> empresaComum = _context.Empresa
                .Where(e => e.CNPJ == CNPJ)
                .Where(e => e.Ativo == true);

            string database = "";
            foreach (Empresa p in empresaComum)
            {
                database = p.Database;
            }

            if (!string.IsNullOrEmpty(database))
            {
                Program.BancoDeDadosAplicacao = database;
                if (Program.BancoDeDadosAplicacao != null)
                {
                    //como alterar o SalesWebMvcContext para a aplicação alterar o banco de dados
                }

                //verifica se a empresa existe na base aplicação e resgata as informações
                IQueryable<Empresa> empresaAplicacao = _contextAplicacao.Empresa
                    .Where(e => e.CNPJ == CNPJ)
                    .Where(e => e.Database == database)
                    .Where(x => x.Ativo == true);

                foreach (Empresa item in empresaAplicacao)
                {
                    Program.EmpresaId = item.Id;
                }

                //verifica o acesso do usuario
                IQueryable<Pessoa> acesso = _contextAplicacao.Pessoa
                    .Where(p => p.PessoaUsuario.Usuario == login.Usuario)
                    .Where(p => p.PessoaUsuario.PessoaUsuarioSenha.Senha == login.Senha && p.PessoaUsuario.PessoaUsuarioSenha.Ativo == true)
                    .Where(p => p.Deletado == false)
                    .Where(p => p.EmpresaId == Program.EmpresaId);
                if (acesso.GetEnumerator().MoveNext() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
