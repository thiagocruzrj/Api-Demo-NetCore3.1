using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Api.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        public Guid ProviderId { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(100, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(100, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 5)]
        public string Description { get; set; }
        public string ImagemUpload { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        public decimal Value { get; set; }
        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }
        [ScaffoldColumn(false)]
        public string ProviderName { get; set; }
    }
}
