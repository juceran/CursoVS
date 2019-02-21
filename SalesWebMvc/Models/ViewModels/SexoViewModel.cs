using SalesWebMvc.Models.Enums;
using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SexoViewModel
    {
        public Sexo Sexo { get; set; }
        public IList<Sexo> Sexos { get; set; }
    }
}
