using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.User.Commands.CreateUser
{
    public class RegisterCommandHandler : ICommandHandler<RegisterCommand, RegisterResult>
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IUserRepository _userRepository;
        public RegisterCommandHandler(IUserRepository userRepository, IJwtGenerator jwtGenerator)
        {
            _userRepository = userRepository;
            _jwtGenerator = jwtGenerator;
        }
        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            if(await _userRepository.IsEmailExisted(request.Email))
            {
                throw new Exception("Email is already existed");
            }
            var user = await _userRepository.AddAsync(request.UserName, request.Password,request.Email,request.Phone);
            var token = _jwtGenerator.CreateToken(user.Id,user.Email);
            return new RegisterResult(user.Id,token);
        }
    }
}
