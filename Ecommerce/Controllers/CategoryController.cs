using Ecommerce.Infrastructure.DTOs;
using Ecommerce.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            return Ok(categoryService.GetCategories());
        }

        [HttpPost("AddCategories")]
        public IActionResult AddCategories([FromBody] AddCategoryDto addCategorydto)
        {
            categoryService.AddCategories(addCategorydto);
            return Ok("added category successfully");
        }

        [HttpPut("UpdateCategories")]
        public IActionResult UpdateCategories([FromBody] UpdateCategoryDto updateCategorydto)
        {
            categoryService.UpdateCategories(updateCategorydto);
            return Ok("category updated successfully");
        }

        [HttpDelete("DeleteCategories/{id}")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            await categoryService.DeleteCategoryAsync(id);
            return Ok("Category deleted successfully");
        }

        [HttpPatch("UpdateCategoryName")]
        public async Task<IActionResult> UpdateCategoryName([FromBody] UpdateCategoryNameDto updateCategoryNameDto)
        {
            await categoryService.UpdateCategoryNameAsync(updateCategoryNameDto);
            return Ok("updated category Name");
        }

    }
}
