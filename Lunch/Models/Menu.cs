using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lunch.Models
{
    public class Menu
    {
        [Display(Name = "Id")]
        public int id { set; get; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Укажите имя")]
        public string menu_name { set; get; }

        [Display(Name = "First")]
        [Required(ErrorMessage = "Укажите первое")]
        public string first { set; get; }

        [Display(Name = "Second")]
        [Required(ErrorMessage = "Укажите второе")]
        public string second { set; get; }

        [Display(Name = "Salat")]
        [Required(ErrorMessage = "Укажите салат")]
        public string salat { set; get; }

        [Display(Name = "Drink")]
        [Required(ErrorMessage = "Укажите напиток")]
        public string drink { set; get; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Укажите цену")]
        public string price { set; get; }

        [Display(Name = "Description")]

        public string product_desc { set; get; }

        public int placeId { get; set; }
        public Place place { get; set; }
    }
}
