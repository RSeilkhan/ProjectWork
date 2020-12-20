using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Data
{
    public class DBObjects
    {
        public static void Initial(ApplicationDbContext content)
        {

            if (!content.Places.Any())
            {
                content.Places.AddRange(Places.Select(c => c.Value));
            }
            if (!content.Kitchens.Any())
            {
                content.Kitchens.AddRange(Kitchens.Select(c => c.Value));
            }
            if (!content.Links.Any())
            {
                content.AddRange(new Link { link_name = "Наш сайт", url = "http://qaganat24.kz/", type = "site", place = Places["Qaganat"] },
                        new Link { link_name = "Мы в вк", url = "https://vk.com/kaganatkz", type = "vk", place = Places["Qaganat"] },
                        new Link { link_name = "Следи за нами в инстаграм", url = "https://www.instagram.com/qaganat_ashana/?hl=ru", type = "instagram", place = Places["Qaganat"] },

                        new Link { link_name = "Следи за новостями в нашем инстаграм", url = "https://www.instagram.com/tagam_kazakhstan/?hl=ru", type = "instagram", place = Places["Тагам"] },

                        new Link { link_name = "Наша страница в инстаграм", url = "https://www.instagram.com/perekycitymixx/?hl=ru", type = "instagram", place = Places["Перекуcity Mixx"] }
                        );
            }
            if (!content.Menus.Any())
            {
                content.AddRange(
                    new Menu { place = Places["Qaganat"], menu_name = "Меню сет 600тг", first = "Суп куриный", second = "Котлета из говядины с овощами", salat = "Греческий", drink = "Чай", price = "800", product_desc = "Классический ланч из первого и второго блюда" },
                    new Menu { place = Places["Qaganat"], menu_name = "Меню сет 800тг", first = "Суп говяжий", second = "Котлета изюминка мини", salat = "Капустный", drink = "Чай", price = "600", product_desc = "Вкусный не дорогой обед" },

                    new Menu { place = Places["Тагам"], menu_name = "Ланч обед #1", first = "Суп грибной", second = "Плов из курицы", salat = "Морковный", price = "900", drink = "Кампот", product_desc = "Сытный обед" },
                    new Menu { place = Places["Тагам"], menu_name = "Ланч обед #2", first = "Борщ", second = "Манты", salat = "Морковный", drink = "Дюшес/Кампот", price = "900", product_desc = "Ланч" },
                    new Menu { place = Places["Тагам"], menu_name = "Ланч обед #3", first = "Каша рисовая", second = "Жареная картошка", salat = "Морковный", drink = "Дюшес/Кампот", price = "1200", product_desc = "Вкусный ланч" },

                    new Menu { place = Places["Перекуcity Mixx"], menu_name = "Бизнес Ланч #1", first = "Каша геркулес", second = "Пельмени", salat = "Капустный", drink = "Чай/Кампот", price = "1000", product_desc = "Бизнес ланч, сытный" },
                    new Menu { place = Places["Перекуcity Mixx"], menu_name = "Бизнес Ланч #2", first = "Суп чечевичный", second = "Бефстроганов", salat = "Свежий", drink = "Чай/Кампот", price = "1000", product_desc = "Бизнес ланч, сытный" }
                    );

            }

            content.SaveChanges();

        }
        private static Dictionary<string, Place> place;
        public static Dictionary<string, Place> Places
        {
            get
            {
                if (place == null)
                {
                    var list = new Place[]
                    {
                          new Place
                           {

                               place_name = "Qaganat",
                               short_desc = "Команда Qaganat – это большая семья, которая заботится о каждом госте! Каждый день мы готовим для Вас с душой и любовью!",
                               desc = "Сеть столовых QAGANAT была основана в 1996 году. Сегодня QAGANAT - это динамично развивающаяся компания, которая зарекомендовала себя как уютное место, где можно быстро и вкусно поесть по доступной цене! Успешно работает уже 26 столовых QAGANAT в городах Алматы, Нур-Султан и Караганда. Во всех наших столовых действует «free lo and sel ie service» и мы работаем круглосуточно без выходных. Концепция столовых QAGANAT отличается ярким и узнаваемым логотипом, продуманным меню, и огромным выбором блюд из качественных и свежих продуктов.",
                               av_price = "700-2000 тг",
                               img = "/img/qaganat.png",
                               address = "пр. Абая, 48В, уг. реки Есентай",
                               phone = "8 (727) 243-8871",
                               Kitchen = Kitchens["Русская"]

                           },
                            new Place
                            {

                                place_name = "Тагам",
                                short_desc = "Сеть столовых «Тағам»‎",
                                desc = "Сеть столовых «Тағам» в Алматы, Нұр-Сұлтан, ПавлодарАтырау,Қызылорда. 10 лет на рынке! Более 800 видов блюд",
                                av_price = "1000-1200 тг",
                                img = "/img/tagam.jpg",
                                address = "улица Жандосова 1/1",
                                phone = "8 (7272) 55-07-26",
                                Kitchen = Kitchens["Казахская"]
                            },
                             new Place
                             {

                                 place_name = "Перекуcity Mixx",
                                 short_desc = "«ПеркуCity Mixx» – это уникальный ресторанный комплекс, который разбит на три этажа, каждый из которых обладает своим меню.",
                                 desc = "На первом этаже вы можете отведать вкуснейшую выпечку, супы вторые блюда, салаты, десерты и закуски. На втором этаже находится бар с напитками, закусками и элитным мороженным на любой вкус, а также с большим выбором авторских десертов. На третьем этаже вас ожидают сочные стейки, приготовленные на открытом огне и салаты, которые идеально дополняют мясные блюда. Вы также можете заказать блюда с оригинальными и уникальными рецептами из нашего авторского меню Любой желающий может расположиться на одном из трех этажей, не зависимо от того, на каком этаже была совершенна покупка. Ресторанный комплекс «ПерекуCityMixx» предлагает также ежедневные бизнес-ланчи и комплексные обеды.",
                                 av_price = " 700-1500 тг",
                                 img = "/img/perekucity.jpg",
                                 address = "ул. Шевченко, 99 (уг. ул. Байтурсынова)",
                                 phone = "+7 (771) 581‒61‒47, +7 (727) 313‒22‒12",
                                 Kitchen = Kitchens["Русская"]
                             }
                    };

                    place = new Dictionary<string, Place>();
                    foreach (Place el in list)
                        place.Add(el.place_name, el);
                }
                return place;
            }
        }

        private static Dictionary<string, Kitchen> kitchen;
        public static Dictionary<string, Kitchen> Kitchens
        {
            get
            {
                if (kitchen == null)
                {
                    var list = new Kitchen[]
                    {
                        new Kitchen{kitchen_name = "Казахская"},
                        new Kitchen{kitchen_name = "Итальянская"},
                        new Kitchen{kitchen_name = "Французкая"},
                        new Kitchen{kitchen_name = "Восточная"},
                        new Kitchen{kitchen_name = "Русская"}
                    };

                    kitchen = new Dictionary<string, Kitchen>();
                    foreach (Kitchen el in list)
                        kitchen.Add(el.kitchen_name, el);
                }
                return kitchen;
            }
        }


    }
}
