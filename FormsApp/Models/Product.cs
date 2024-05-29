using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Ürün adı zorunlu")]
        [Display(Name = "Ürün adı")]
        [StringLength(100, ErrorMessage = "Ürün adı minimum {2}, maksimum {1} karakter olmalıdır", MinimumLength = 10)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Fiyat zorunlu")]
        [Display(Name = "Fiyat")]
        [Range(10, 100000, ErrorMessage = "Fiyat {1} ile {2} arasında olmalıdır.")]
        public decimal Price { get; set; }

        [Display(Name = "Fotoğraf")]
        public string? Image { get; set; }
        public bool isActive { get; set; }

        [Required(ErrorMessage = "Kategori zorunlu")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

    }
}