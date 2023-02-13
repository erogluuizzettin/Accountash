using Accountash.Application.Abstractions;
using Accountash.Domain.AppEntities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accountash.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager = null)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(x => x.Email == request.EMailOrUserName || x.UserName == request.EMailOrUserName).FirstOrDefaultAsync();
            if (user == null) throw new Exception("User not found.");

            var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("User password is wrong.");

            List<string> roles = new();

            LoginResponse response = new()
            {
                EMail = user.Email,
                FullName = user.FullName,
                UserId = user.Id,
                Token = await _jwtProvider.CreateTokenAsync(user, roles)
            };

            return response;
        }
    }
}
