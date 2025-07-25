using Ecommerce.Infrastructure.Entities;

namespace Ecommerce.Infrastructure.Interfaces
{
    public interface IProductService
    {
        public List<Products> GetProducts();
    }
}
