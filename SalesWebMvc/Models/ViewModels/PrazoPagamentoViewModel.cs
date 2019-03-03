using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class PrazoPagamentoViewModel
    {
        public PrazoPagamento PrazoPagamento { get; set; }
        public ICollection<PrazoPagamento> PrazoPagamentos { get; set; }
    }
}
