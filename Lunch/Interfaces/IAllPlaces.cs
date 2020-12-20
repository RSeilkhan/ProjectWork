using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Interfaces
{
    public interface IAllPlaces
    {
        IEnumerable<Place> GetAllPlaces();

        IEnumerable<Place> GetFavouritePlaces { get; }

        IEnumerable<Place> Places { get; }

        Place getObject(int placeId);

    }
}
