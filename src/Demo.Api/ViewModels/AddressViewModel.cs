using System;
using System.ComponentModel.DataAnnotations;

namespace Demo.Api.ViewModels
{
    public class AddressViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(200, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(50, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 1)]
        public string Number { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(100, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(8, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(100, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "Field {0} must be filled")]
        [StringLength(50, ErrorMessage = "Field {0} must have between {2} and {1} characters", MinimumLength = 2)]
        public string State { get; set; }

        public Guid ProviderId { get; set; }
    }
}
