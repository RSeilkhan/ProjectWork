using Lunch.Interfaces;
using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.mocks
{
    public class MockLinks : IAllLinks
    {
        private readonly IAllPlaces _places = new MockPlace();
        public IEnumerable<Link> Links
        {
            get
            {
                return new List<Link>
                {
                    new Link{link_name = "Наш сайт", url = "http://qaganat24.kz/", type="site", place = _places.GetAllPlaces().First()},
                    new Link{link_name = "Мы в вк", url = "https://vk.com/kaganatkz", type="vk", place = _places.GetAllPlaces().First()},
                    new Link{link_name = "Следи за нами в инстаграм", url = "https://www.instagram.com/qaganat_ashana/?hl=ru", type="instagram", place = _places.GetAllPlaces().First()},

                    new Link{link_name = "Следи за новостями в нашем инстаграм", url = "https://www.instagram.com/tagam_kazakhstan/?hl=ru", type="instagram", place = _places.GetAllPlaces().ElementAt(2)},

                    new Link{link_name = "Наша страница в инстаграм", url = "https://www.instagram.com/perekycitymixx/?hl=ru", type="instagram", place = _places.GetAllPlaces().Last()},
                };
            }
        }

        public Link getObjectLink(int linkId)
        {
            throw new NotImplementedException();
        }
    }
}
