using System;

namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        //campos comuns nas tabelas
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Deletado { get; set; }
        public DateTime DeletadoData { get; set; }

        //referencias de relacionamentos
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
    }
}
