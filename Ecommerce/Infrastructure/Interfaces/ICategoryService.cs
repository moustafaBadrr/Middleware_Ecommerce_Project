using Ecommerce.Infrastructure.DTOs;
using Ecommerce.Infrastructure.Entities;

namespace Ecommerce.Infrastructure.Interfaces
{
    public interface ICategoryService
    {

        public List<Categories> GetCategories();
        public void AddCategories(AddCategoryDto addCategorydto);
        public void UpdateCategories(UpdateCategoryDto updateCategorydto);
        public Task DeleteCategoryAsync(int id);
        public Task UpdateCategoryNameAsync(UpdateCategoryNameDto updateCategoryNameDto);
    }
}
