using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SubMenuViewModel
    {
        public MenuLi MenuLi { get; set; }
        public ICollection<MenuLi> menuLi { get; set; }

        public int MenuUlId { get; set; }
        public IEnumerable<SelectListItem> Menus { get; set; }
    }
}
