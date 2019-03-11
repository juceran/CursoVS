using SalesWebMvc.Models;
using SalesWebMvc.Comuns;
using SalesWebMvc.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


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
            var CNPJ = RemoverCaracteres.StringSemFormatacao(login.CNPJ);

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

                return true;
            }
            else
            {
                return false;
            }          
        }
    }
}
