using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        [Range(0.01, 10000.00)]

        public decimal Price { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public string? ImagePath { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
