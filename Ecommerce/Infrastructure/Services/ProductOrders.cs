using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.Entities;
using Ecommerce.Infrastructure.Interfaces;

namespace Ecommerce.Infrastructure.Services
{
	public class ProductOrders :IOrderService
	{
		internal readonly EcommerceDbContext _context;
		public ProductOrders(EcommerceDbContext context)
		{
			_context = context;
		}
		
		public List<Orders> GetOrders()
		{
			return _context.Orders.ToList();
		}
	}
}
