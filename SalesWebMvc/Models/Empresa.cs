using System;

namespace SalesWebMvc.Models
{
    public class Empresa
    {  
        // alteracao teste 2
        public int Id { get; set; }
        public string Database { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
            
        public DateTime DataAbertura { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string CEP { get; set; }


        //campos comuns nas tabelas
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Deletado { get; set; }
        public DateTime DeletadoData { get; set; }

        //referencias de relacionamentos
        //public Pessoa Pessoa { get; set; }
        public Departamento Departamento { get; set; }
    }
}
