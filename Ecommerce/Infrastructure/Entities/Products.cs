using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Infrastructure.Entities
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //public Categories? Category { get; set; }
        //public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
    }


}
