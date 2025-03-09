using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Registration_v2.Entity;

namespace Registration_v2
{
    public class ApplicationDBContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
