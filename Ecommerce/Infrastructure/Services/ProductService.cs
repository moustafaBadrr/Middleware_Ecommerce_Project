using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.Entities;
using Ecommerce.Infrastructure.Interfaces;

namespace Ecommerce.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        internal readonly EcommerceDbContext _context;
        public ProductService(EcommerceDbContext context)
        {
            _context = context;
        }
        public List<Products> GetProducts()
        {
            return _context.Products.ToList();
        }
		
	}
}
