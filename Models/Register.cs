using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class Register : ApplicationUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public override string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The confirm password did not match the password")]
        public string ConfirmPassword { get; set; }
    }
}
