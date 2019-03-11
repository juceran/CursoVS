using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class MenuViewModel
    {
        public MenuUl MenuUl { get; set; }
        public ICollection<MenuUl> menuUl { get; set; }
    }
}
