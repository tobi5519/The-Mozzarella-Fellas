using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace The_Mozzarella_Fellas.Models
{
    public class Pizza : DbContext
    {
        public int Id {get; set; }
        [Required]
        public string Name { get; set; }
        public string Toppings { get; set; }
        [Required]
        public int Price { get; set; }


    }
}