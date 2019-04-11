using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace CrudDelicious.Models
{
    public class Chef

    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate {get; set; }
        public List<Dish> DishesMade {get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}