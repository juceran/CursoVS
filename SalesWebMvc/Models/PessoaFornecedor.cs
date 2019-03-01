using SalesWebMvc.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class PessoaFornecedor : CamposComuns
    {
        public bool Fornecedor { get; set; }

        //Relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }
    }
}
