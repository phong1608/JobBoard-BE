using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Job.Query.GetJobByUserId
{

    public class GetJobByUserIdQueryHandler : IQueryHandler<GetJobByUserIdQuery, GetJobByUserIdResult>
    {
        private readonly IJobRepository _jobRepository;
        public GetJobByUserIdQueryHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<GetJobByUserIdResult> Handle(GetJobByUserIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _jobRepository.GetByUserId(request.UserId);

            return new GetJobByUserIdResult(result.ToList());
        }
    }
}
