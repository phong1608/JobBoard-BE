using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Application.Query.GetApplicationByUserId
{
    internal class GetApplicationByUserIdHandler : IQueryHandler<GetApplicationByUserId, GetApplicationByUserIdResult>
    {
        private readonly IApplicationRepository _applicationRepository;
        public GetApplicationByUserIdHandler(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<GetApplicationByUserIdResult> Handle(GetApplicationByUserId request, CancellationToken cancellationToken)
        {
            var result = await _applicationRepository.GetApplicationsByUserId(request.UserId);
            return new GetApplicationByUserIdResult(result.ToList());
        }
    }
}
