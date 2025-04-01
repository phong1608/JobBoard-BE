using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.User.Commands.Login
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginResult>
    {
        private readonly IAuthService _authService;
        public LoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var token = await _authService.Login(request.Email, request.Password);
            return new LoginResult(token);
        }
    }
}
