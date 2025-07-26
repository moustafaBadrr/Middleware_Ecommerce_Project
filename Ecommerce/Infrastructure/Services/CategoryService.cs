using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.Entities;
using Ecommerce.Infrastructure.Interfaces;

namespace Ecommerce.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        internal readonly EcommerceDbContext _context;
        public CategoryService(EcommerceDbContext context)
        {
            _context = context;
        }
        public List<Categories> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
