using Lunch.Data;
using Lunch.Interfaces;
using Lunch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Repositories
{
    public class MenuRepository : IAllMenus
    {
        private readonly ApplicationDbContext appDBContent;

        public MenuRepository(ApplicationDbContext appDBContent) { 
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Menu> Menus => appDBContent.Menus.Include(p => p.place);

        public Menu getObjectMenu(int menuId) => appDBContent.Menus.FirstOrDefault(p => p.id == menuId);
    }
}
