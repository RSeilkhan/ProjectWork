using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.ViewModels
{
    public class PlacesData
    {
        public IEnumerable<Link> Links { get; set; }
        public IEnumerable<Menu> Menus { get; set; }
        public IEnumerable<Place> Places { get; set; }

    }
}
