using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Data.Models
{
    public class Food
    {
        public int FoodId  { get; set; }

        [Required(ErrorMessage = "Food Name is Not Empty")]
        public string Name { get; set; }
        public string  Description { get; set; }
        [Required(ErrorMessage = "Food Price is Not Empty")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Select Image")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Food stock is Not Empty")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Food Category is Not Empty")]
        public int CategoryId { get; set; }
        public virtual Category Category  { get; set; }

    }
}
