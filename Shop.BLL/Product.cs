using System.ComponentModel.DataAnnotations;

namespace Shop.BLL
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}