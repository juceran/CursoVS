using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class EmpresaViewModel
    {
        public Empresa Empresa { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
    }
}
