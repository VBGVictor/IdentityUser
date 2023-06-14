using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.DTO_s
{
    public class CreateUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirmation { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Brithiday { get; set; }

    }
}
