using System.ComponentModel.DataAnnotations;

namespace SvinitEnterprises.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "The password must be between 5 and 10 characters.")]
        public string Password { get; set; }
    }
}