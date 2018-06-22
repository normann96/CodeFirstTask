using System.ComponentModel.DataAnnotations;

namespace ShopInfo
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
    }
}