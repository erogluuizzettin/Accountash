using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;

public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;
