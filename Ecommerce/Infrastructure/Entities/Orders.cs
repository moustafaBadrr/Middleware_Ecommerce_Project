using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Infrastructure.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string? Status { get; set; } = "Pending";
        public decimal? TotalAmount { get; set; }
        public string? ShippingAddress { get; set; }

        //public Users User { get; set; } = null!;
        //public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
        //public Payment? Payment { get; set; }
        //public Shipping? Shipping { get; set; }
    }


}
