using Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using Accountash.Domain.AppEntities.Identity;

namespace Accountash.Application.Services.AppServices;

public interface IRoleService
{
    Task AddAsync(CreateRoleCommand request);
    Task UpdateAsync(AppRole role);
    Task DeleteAsync(AppRole role);
    Task<IList<AppRole>> GetAllRolesAsync();
    Task<AppRole> GetByIdAsync(string id);
    Task<AppRole> GetByCodeAsync(string code);
    Task<bool> CheckCode(string code);
}
