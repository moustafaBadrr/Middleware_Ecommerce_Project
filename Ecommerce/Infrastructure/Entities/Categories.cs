using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Infrastructure.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? ParentCategoryId { get; set; }

        //public Categories? ParentCategory { get; set; }
        //public ICollection<Products> Products { get; set; } = new List<Products>();
    }


}
