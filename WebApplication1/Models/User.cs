using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime Brithiday { get; set; }

        public User(): base() { }

    }
}
