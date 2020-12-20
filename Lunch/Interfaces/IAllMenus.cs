using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Interfaces
{
    public interface IAllMenus
    {
        IEnumerable<Menu> Menus { get; }
        Menu getObjectMenu(int menuId);

    }
}
