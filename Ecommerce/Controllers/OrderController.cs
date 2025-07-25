using Ecommerce.Infrastructure.Interfaces;
using Ecommerce.Infrastructure.Services;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class OrderController : ControllerBase
	{
		public readonly IOrderService orderService;
		public OrderController(IOrderService orderService)
		{
			this.orderService = orderService;
		}

		[HttpGet("GetOreders")]
		public IActionResult GetStudents()
		{
			return Ok(orderService.GetOrders());
		}
	}
}
