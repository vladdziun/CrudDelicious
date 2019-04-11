using System.ComponentModel.DataAnnotations;
using System;

namespace CrudDelicious.Models
{
    public class Dish

    {
        [Key]
        public int DishId { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        public Chef Creator { get; set; }
        public int ChefId {get; set; }
        public int Tastiness { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}