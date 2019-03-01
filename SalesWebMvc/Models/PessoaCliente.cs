using SalesWebMvc.Models.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Resources;

namespace SalesWebMvc.Models
{
    public class PessoaCliente : CamposComuns
    {
        public bool Cliente { get; set; }

        [DataType(dataType: DataType.Currency)]
        [Display(Name = "Limite de Crédito")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? LimiteCredito { get; set; }
                                           
        //Relacionamentos
        public virtual Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
