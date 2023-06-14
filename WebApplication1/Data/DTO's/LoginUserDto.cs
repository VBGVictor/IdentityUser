using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data.DTO_s
{
    public class LoginUserDto
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
