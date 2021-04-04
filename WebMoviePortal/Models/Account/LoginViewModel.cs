using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMoviePortal.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "User name")]
        [Required]
        public string  UserName { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
