using ProjectHammer.Service.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ProjectHammer.Service.Models
{

    public class LoginPoco : ILogin
    {
        public int LoginNo { get; set; }

        [Required(ErrorMessage = "Enter user name")]
        [StringLength(20, ErrorMessage = "Limit User name to 20 characters.")]
        [Display(Name = "Username")]
        public string LoginUserName { get; set; }

        [Required(ErrorMessage = "Enter password category")]
        [StringLength(20, ErrorMessage = "Limit password to 20 characters.")]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }

    }

   
}
