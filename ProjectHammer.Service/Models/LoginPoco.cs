using ProjectHammer.Service.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ProjectHammer.Service.Models
{
    /// <summary>
    /// Login class
    /// </summary>
    public class LoginPoco : ILogin
    {
        /// <summary>
        /// Gets or sets LoginNo
        /// </summary>
        public int LoginNo { get; set; }

        /// <summary>
        /// Gets or sets username
        /// </summary>
        [Required(ErrorMessage = "Enter user name")]
        [StringLength(20, ErrorMessage = "Limit User name to 20 characters.")]
        [Display(Name = "Username")]
        public string LoginUserName { get; set; }

        /// <summary>
        /// Gets or sets passwor
        /// </summary>
        [Required(ErrorMessage = "Enter password category")]
        [StringLength(20, ErrorMessage = "Limit password to 20 characters.")]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }

    }

   
}
