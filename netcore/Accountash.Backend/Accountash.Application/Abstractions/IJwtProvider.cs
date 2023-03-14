using Accountash.Domain.AppEntities.Identity;

namespace Accountash.Application.Abstractions;

public interface IJwtProvider
{
    Task<string> CreateTokenAsync(AppUser user, List<string> roles);
}
