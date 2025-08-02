using Dapper;
using Ecommerce.Infrastructure.Context;
using Ecommerce.Infrastructure.DTOs;
using Ecommerce.Infrastructure.Entities;
using Ecommerce.Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;

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

        public void AddCategories(AddCategoryDto addCategorydto)
        {
            Categories newCategory = new Categories();
            newCategory.Name=addCategorydto.Name;
            newCategory.Description=addCategorydto.Description;
            _context.Categories.Add(newCategory);
            _context.SaveChanges();
        }

        public void UpdateCategories(UpdateCategoryDto updateCategorydto)
        {
            var categoryToUpdate = _context.Categories.First(c => c.CategoryId == updateCategorydto.CategoryId);
            categoryToUpdate.Name = updateCategorydto.Name;
            categoryToUpdate.Description = updateCategorydto.Description;
            _context.Categories.Update(categoryToUpdate);
            _context.SaveChanges();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var connection = new SqlConnection("Server=localhost;Database=Ecommerce;User Id=sa;Password=H@s112233you;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");
            string query = "delete from Categories where CategoryId=@Id";
            await connection.ExecuteAsync(query,new {Id=id});
        }

        public async Task UpdateCategoryNameAsync(UpdateCategoryNameDto updateCategoryNameDto)
        {
            var connection = new SqlConnection("Server=localhost;Database=Ecommerce;User Id=sa;Password=H@s112233you;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");
            string query = "update Categories set Name=@CategoryName where CategoryId=@categoryId";
            await connection.ExecuteAsync(query, new { CategoryName = updateCategoryNameDto.Name, categoryId =updateCategoryNameDto.CategoryId });

        }
    }
}
