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
    public class PlaceRepository : IAllPlaces
    {

        private readonly ApplicationDbContext appDBContent;

        public PlaceRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Place> Places => appDBContent.Places.Include(p => p.Kitchen);

        public IEnumerable<Place> GetFavouritePlaces => appDBContent.Places.Where(p => p.isFavourite).Include(k => k.Kitchen);
        public IEnumerable<Place> GetAllPlaces()
        {
            return appDBContent.Places;
        }

        public Place getObject(int placeId) => appDBContent.Places.FirstOrDefault(p => p.id == placeId);

    }
}
