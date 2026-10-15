using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruSqlShowcase.Brand
{
    [Table("Brands")]
    public class BrandBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
