using Lunch.Interfaces;
using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.mocks
{
    public class MockMenus : IAllMenus
    {
        private readonly IAllPlaces _places = new MockPlace();
        public IEnumerable<Menu> Menus
        {
            get
            {
                return new List<Menu>
                {

                    new Menu{ menu_name = "Меню сет 600тг", first = "Суп куриный", second="Котлета из говядины с овощами", salat="Греческий", drink="Чай" , price="800", product_desc="Классический ланч из первого и второго блюда", place = _places.GetAllPlaces().First()},
                    new Menu{ menu_name = "Меню сет 800тг", first = "Суп говяжий", second="Котлета изюминка мини", salat="Капустный", drink="Чай", price="600", product_desc="Вкусный не дорогой обед", place = _places.GetAllPlaces().First()},

                    new Menu{ menu_name = "Ланч обед #1", first = "Суп грибной", second="Плов из курицы", salat="Морковный", drink="Кампот", product_desc="Сытный обед", place = _places.GetAllPlaces().Last()},
                    new Menu{ menu_name = "Ланч обед #2", first = "Борщ", second="Манты", salat="Морковный", drink="Дюшес/Кампот", price="900", product_desc="Ланч", place = _places.GetAllPlaces().Last()},
                    new Menu{ menu_name = "Ланч обед #3", first = "Каша рисовая", second="Жареная картошка", salat="Морковный", drink="Дюшес/Кампот", price="1200", product_desc="Вкусный ланч", place = _places.GetAllPlaces().Last()},

                    new Menu{ menu_name = "Бизнес Ланч #1", first = "Каша геркулес", second="Пельмени", salat="Капустный", drink="Чай/Кампот", price="1000", product_desc="Бизнес ланч, сытный", place = _places.GetAllPlaces().ElementAt(2)},
                    new Menu{ menu_name = "Бизнес Ланч #2", first = "Суп чечевичный", second="Бефстроганов", salat="Свежий", drink="Чай/Кампот", price="1000", product_desc="Бизнес ланч, сытный", place = _places.GetAllPlaces().ElementAt(2)},
                };
            }
        }

        public Menu getObjectMenu(int menuId)
        {
            throw new NotImplementedException();
        }
    }
}
