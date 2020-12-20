using Lunch.Interfaces;
using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.mocks
{
    public class MockKitchen : IAllKitchens
    {

        public IEnumerable<Kitchen> GetAllKitchens()
        {
            return new List<Kitchen>
                {
                    new Kitchen{kitchen_name = "Казахская"},
                    new Kitchen{kitchen_name = "Итальянская"},
                    new Kitchen{kitchen_name = "Французкая"},
                    new Kitchen{kitchen_name = "Восточная"},
                    new Kitchen{kitchen_name = "Русская"}

                };
        }
    }
}
