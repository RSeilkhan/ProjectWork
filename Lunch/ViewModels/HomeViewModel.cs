using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Place> favPlaces { get; set; }
    }
}
