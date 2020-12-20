using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lunch.Models
{
    public class Place
    {
        [Display(Name = "Id")]
        public int id { set; get; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Укажите имя")]

        public string place_name { set; get; }


        [Display(Name = "Short description")]
        [Required(ErrorMessage = "Укажите краткое описание")]

        public string short_desc { set; get; }


        [Display(Name = "Description")]
        [Required(ErrorMessage = "Укажите полное описание")]
        public string desc { set; get; }


        [Display(Name = "Average price")]
        [Required(ErrorMessage = "Укажите средний звонок")]
        public string av_price { set; get; }


        [Display(Name = "Images")]
        [Required(ErrorMessage = "Укажите фотографию")]
        public string img { set; get; }


        [Display(Name = "Address")]
        [Required(ErrorMessage = "Укажите адрес")]
        public string address { set; get; }


        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Укажите номер телефона")]
        [Phone(ErrorMessage = "Некорректный номер телефона")]
        public string phone { set; get; }


        [Display(Name = "Is Favourite")]
        public bool isFavourite { set; get; }

        [Display(Name = "Kitchen")]

        public int kitchenId { get; set; }
        public virtual Kitchen Kitchen { get; set; }

        public ICollection<Menu> Menus { get; set; }
        public ICollection<Link> Links { get; set; }

        //public ICollection<Kitchen> Kitchens { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.place_name))
            {
                errors.Add(new ValidationResult("Введите имя!", new List<string>() { "Name" }));
            }

            if (string.IsNullOrWhiteSpace(this.phone))
            {
                errors.Add(new ValidationResult("Введите номер!"));
            }

            return errors;
        }


    }
}
