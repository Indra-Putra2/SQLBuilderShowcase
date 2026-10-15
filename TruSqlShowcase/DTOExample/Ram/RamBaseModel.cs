using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruSqlShowcase.Ram
{
    [Table("Rams")]
    public class RamBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? BrandId { get; set; }
        public string? MemoryType { get; set; }
        public int? MemorySpeed { get; set; }
        public string? Module { get; set; }
        public double? TotalCapacity { get; set; }
        public double? FirstWordLatency { get; set; }
        public double? CASLatency { get; set; }
        public double? Rating { get; set; }
        public int? ReviewCount { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public decimal? PricePerGB { get; set; }
    }
}
