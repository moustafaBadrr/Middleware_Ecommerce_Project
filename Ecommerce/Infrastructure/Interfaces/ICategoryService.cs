using Ecommerce.Infrastructure.Entities;

namespace Ecommerce.Infrastructure.Interfaces
{
    public interface ICategoryService
    {

        public List<Categories> GetCategories();
    }
}
