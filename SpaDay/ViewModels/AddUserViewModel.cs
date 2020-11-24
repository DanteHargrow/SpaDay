using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15,MinimumLength =5,ErrorMessage ="Username needs to be between 5 and 15 characters.  ")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password required")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Password must be between 6 and 20 characters.")]
        public string Password { get; set; }
        

        [Required(ErrorMessage ="Field must be filled out")]
        [Compare("Password",ErrorMessage ="Passords must be the same!")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }






    }
}
