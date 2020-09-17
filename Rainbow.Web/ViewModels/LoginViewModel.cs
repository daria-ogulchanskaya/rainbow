using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rainbow.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string ReturnUrl { get; set; }

        [Required]
        public IEnumerable<AuthenticationScheme> ExternalProviders { get; set; }
    }
}
