using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLabModels.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Must be 5-20 characters")]
        [MaxLength(20, ErrorMessage = "Must be 5-20 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Must be at 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at 10-50 characters")]
        public string Password { get; set; }
    }
}
