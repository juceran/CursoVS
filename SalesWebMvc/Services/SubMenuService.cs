using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class SubMenuService
    {
        private readonly SalesWebMvcContext _context;

        public SubMenuService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public bool SubMenuExiste(MenuLi menuLi)
        {
            var temp = _context.MenuLi.Where(d => d.SubMenu == menuLi.SubMenu).OrderBy(d => d.SubMenu);
            foreach (MenuLi item in temp)
            {
                if (item.SubMenu == menuLi.SubMenu)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
