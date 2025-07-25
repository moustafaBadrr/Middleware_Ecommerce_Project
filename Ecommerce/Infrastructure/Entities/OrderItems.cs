using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Infrastructure.Entities
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //public Orders Order { get; set; } = null!;
        //public Products Product { get; set; } = null!;
    }

}
