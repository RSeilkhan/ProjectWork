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
    public class KitchenRepository : IAllKitchens
    {

        private readonly ApplicationDbContext appDBContent;

        public KitchenRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Kitchen> GetAllKitchens()
        {
            return appDBContent.Kitchens;
        }

    }
}
