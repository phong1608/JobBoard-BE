using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Application.Query.GetApplicationByJobId
{
    internal class GetApplicationByJobIdHandler : IQueryHandler<GetApplicationByJobIdQuery, GetApplicationByJobIdResult>
    {
        private readonly IApplicationRepository _applicationRepository;
        public GetApplicationByJobIdHandler(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<GetApplicationByJobIdResult> Handle(GetApplicationByJobIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _applicationRepository.GetApplicationsByJobId(request.JobId);
            return new GetApplicationByJobIdResult(result.ToList());
        }
    }
}
