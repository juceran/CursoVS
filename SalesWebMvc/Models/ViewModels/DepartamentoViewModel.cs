using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class DepartamentoViewModel
    {
        public Departamento Departamento { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
