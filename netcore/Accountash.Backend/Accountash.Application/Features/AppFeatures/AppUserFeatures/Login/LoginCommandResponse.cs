namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login;

public sealed record LoginCommandResponse(string Token, string EMail, string UserId, string FullName);
