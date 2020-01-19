using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.Api.ViewModels
{
    public class ProviderViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(100, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(14, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 11)]
        public string Document { get; set; }
        public int ProviderType { get; set; }
        public AddressViewModel Address { get; set; }
        public bool Active { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
