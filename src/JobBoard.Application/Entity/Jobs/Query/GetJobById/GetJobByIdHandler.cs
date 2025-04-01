using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Jobs.Query.GetJobById
{
    public class GetJobByIdHandler : IQueryHandler<GetJobById, GetJobByIdResult>
    {
        private readonly IJobRepository _jobRepository;
        public GetJobByIdHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<GetJobByIdResult> Handle(GetJobById request, CancellationToken cancellationToken)
        {
            var result = await _jobRepository.GetByIdAsync(request.Id);
            return new GetJobByIdResult(result);
        }
    }
}
