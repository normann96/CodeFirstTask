using System.ComponentModel.DataAnnotations;

namespace Shop.BLL
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}