using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class UserDbContext : IdentityDbContext<User>
    {

        public UserDbContext(DbContextOptions<UserDbContext> opts) : base(opts)
        {
            
        }

    }
}
