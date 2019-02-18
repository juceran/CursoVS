using SalesWebMvc.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class PessoaFornecedor : CamposComuns
    {
        public bool Fornecedor { get; set; }

        //Relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
