using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace PhoneWebApp.Models
{
    public class PhoneContact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set;  }

        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
        [ValidateNever]
        public string? Address { get; set; }
        [ValidateNever]
        public string? Note { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + "-" + Note?.ToString();

    }
}
