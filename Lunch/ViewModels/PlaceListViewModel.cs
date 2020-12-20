using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.ViewModels
{
    public class PlaceListViewModel
    {
        public IEnumerable<Place> allPlaces { get; set; }
        public IEnumerable<Link> allLinks { get; set; }

        public string currKitchen { get; set; }
    }
}
