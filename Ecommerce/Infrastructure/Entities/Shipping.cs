using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Infrastructure.Entities
{
    public class Shipping
    {
        [Key]
        public int ShippingId { get; set; }
        public int OrderId { get; set; }
        public string? Carrier { get; set; }
        public string? TrackingNumber { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Status { get; set; }

        //public Orders Order { get; set; } = null!;
    }


}
