using System.ComponentModel.DataAnnotations;

namespace Rainbow.Web.ViewModels
{
    public class FacebookLoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string ReturnUrl { get; set; }
    }
}
