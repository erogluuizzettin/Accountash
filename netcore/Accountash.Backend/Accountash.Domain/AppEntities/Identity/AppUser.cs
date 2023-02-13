using Microsoft.AspNetCore.Identity;

namespace Accountash.Domain.AppEntities.Identity
{
    public sealed class AppUser : IdentityUser<string>
    {
        public string FullName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpires { get; set; }
    }
}
