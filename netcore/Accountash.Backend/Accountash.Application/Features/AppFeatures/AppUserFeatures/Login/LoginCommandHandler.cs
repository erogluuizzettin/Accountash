using Accountash.Application.Abstractions;
using Accountash.Application.Messaging;
using Accountash.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager = null)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(x => x.Email == request.EMailOrUserName || x.UserName == request.EMailOrUserName).FirstOrDefaultAsync();
            if (user == null) throw new Exception("User not found.");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("User password is wrong.");

            List<string> roles = new();

            LoginCommandResponse response = new(
                user.Email, 
                user.FullName, 
                user.Id, 
                await _jwtProvider.CreateTokenAsync(user, roles));

            return response;
        }
    }
}
