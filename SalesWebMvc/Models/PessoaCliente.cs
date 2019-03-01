using SalesWebMvc.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class PessoaCliente : CamposComuns
    {
        public bool? Cliente { get; set; }

        [DataType(dataType: DataType.Currency)]
        [Display(Name = "Limite de Crédito")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? LimiteCredito { get; set; }

        //Relacionamentos
        public virtual Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public int FormaPagamentoId { get; set; }
    }
}
