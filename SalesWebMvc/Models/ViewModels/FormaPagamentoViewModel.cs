using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class FormaPagamentoViewModel
    {
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<FormaPagamento> FormaPagamentos { get; set; }
    }
}
