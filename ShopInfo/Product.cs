using System.ComponentModel.DataAnnotations;

namespace ShopInfo
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(15)]
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Coast { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}