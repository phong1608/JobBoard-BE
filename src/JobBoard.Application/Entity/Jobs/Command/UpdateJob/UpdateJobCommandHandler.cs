using FluentValidation.Results;
using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Jobs.Command.UpdateJob
{
    public class UpdateJobCommandHandler : ICommandHandler<UpdateJobCommand, UpdateJobResult>
    {
        private readonly IJobRepository _jobRepository;
        public UpdateJobCommandHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<UpdateJobResult> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            var result = await _jobRepository.UpdateAsync(request.Title, request.EmpoyerId, request.Description, request.Location, request.Salary);

            return new UpdateJobResult(result);

        }
    }
}
