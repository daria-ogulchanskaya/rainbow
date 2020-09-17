using System;
using System.ComponentModel.DataAnnotations;

namespace Rainbow.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "The Username value cannot exceed 10 characters.")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]    
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
