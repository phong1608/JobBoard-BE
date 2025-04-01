using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Job.Query.GetAllJob
{
    public class GetAllJobHandler : IQueryHandler<GetAllJob, GetAllJobResult>
    {
        private readonly IJobRepository _jobRepository;
        public GetAllJobHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<GetAllJobResult> Handle(GetAllJob request, CancellationToken cancellationToken)
        {
            var result = await _jobRepository.GetAllAsync();
            return new GetAllJobResult(result.ToList());
        }
    }
}
