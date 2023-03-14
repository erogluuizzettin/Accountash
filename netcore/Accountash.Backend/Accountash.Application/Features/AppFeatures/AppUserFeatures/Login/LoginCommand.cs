using Accountash.Application.Messaging;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login;

public sealed record LoginCommand(
    string EMailOrUserName, 
    string Password) : ICommand<LoginCommandResponse>;
