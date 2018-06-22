using System.ComponentModel.DataAnnotations;

namespace CodeFirstTask
{
    public class Provider
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}