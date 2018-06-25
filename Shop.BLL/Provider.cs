using System.ComponentModel.DataAnnotations;

namespace Shop.BLL
{
    public class Provider
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public string City { get; set; }
        public Product Product { get; set; }
    }
}