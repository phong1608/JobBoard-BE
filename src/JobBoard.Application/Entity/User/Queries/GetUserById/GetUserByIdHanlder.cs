using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.User.Queries.GetUserById
{
    public class GetUserByIdHanlder : IQueryHandler<GetUserByIdQuery, GetUSerByIdResult>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdHanlder(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<GetUSerByIdResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetUserById(request.Id);
            return new GetUSerByIdResult(result);
        }
    }
}
