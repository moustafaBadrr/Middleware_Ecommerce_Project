using Ecommerce.Infrastructure.Entities;

namespace Ecommerce.Infrastructure.Interfaces
{
	public interface IOrderService
	{
		public List<Orders> GetOrders();
	}
}
