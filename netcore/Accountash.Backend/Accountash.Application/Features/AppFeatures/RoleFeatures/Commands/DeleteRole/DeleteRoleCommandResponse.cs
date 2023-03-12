using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommandResponse(
        string Message = "The role was successfully deleted.");
}
