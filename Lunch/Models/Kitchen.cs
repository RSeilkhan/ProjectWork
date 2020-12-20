using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lunch.Models
{
    public class Kitchen
    {
        [Display(Name = "Id")]
        public int id { set; get; }

        [Display(Name = "Name")]
        [Required]
        public string kitchen_name { set; get; }

        public List<Place> Places { set; get; }

    }
}
