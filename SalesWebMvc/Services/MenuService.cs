using SalesWebMvc.Context;
using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class MenuService
    {
        private readonly SalesWebMvcContext _context;

        public MenuService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public bool MenuExiste(MenuUl menuUl)
        {
            var menu = _context.MenuUl.Where(d => d.Menu == menuUl.Menu).OrderBy(d => d.Menu);
            foreach (MenuUl item in menu)
            {
                if (item.Menu == menuUl.Menu)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
