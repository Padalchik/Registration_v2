using Microsoft.AspNetCore.Identity;

namespace Registration_v2.Entity
{
    public class CustomUser : IdentityUser
    {
        public byte[]? Avatar { get; set; }
    }
}
