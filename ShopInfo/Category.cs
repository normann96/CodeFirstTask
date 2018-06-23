using System.ComponentModel.DataAnnotations;

namespace ShopInfo
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}