using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(5, ErrorMessage = "Symbol cannot be more than 5 characters")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(15, ErrorMessage = "Company name cannot be more than 15 characters")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Industry cannot be more than 15 characters")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000000)]
        public long MarketCap { get; set; }
    }
}