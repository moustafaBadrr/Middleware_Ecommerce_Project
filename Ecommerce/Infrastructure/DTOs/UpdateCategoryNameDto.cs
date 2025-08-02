namespace Ecommerce.Infrastructure.DTOs
{
    public class UpdateCategoryNameDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
    }
}
