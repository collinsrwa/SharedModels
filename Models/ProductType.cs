using System.ComponentModel.DataAnnotations;

namespace SharedModels.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string ProdType { get; set; }
    }
}