using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lunch.Models
{
    public class Link
    {
        [Display(Name = "Id")]
        public int id { set; get; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Укажите название для ссылки")]
        public string link_name { set; get; }

        [Display(Name = "Url")]
        [Required(ErrorMessage = "Укажите ссылку")]
        [Url(ErrorMessage = "Некорректная ссылка")]

        public string url { set; get; }

        [Display(Name = "Type")]
        public string type { set; get; }
        public int placeId { get; set; }
        public Place place { get; set; }
    }
}
