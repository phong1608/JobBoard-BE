using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Application.Command.CreateApplication
{
    internal class CreateApplicationCommandHandler : ICommandHandler<CreateApplicationCommand, CreateApplicationResult>
    {
        private readonly IApplicationRepository _applicationRepository;
        public CreateApplicationCommandHandler(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<CreateApplicationResult> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
        {
            var result = await _applicationRepository.AddAsync(request.JobId,request.UserId,request.CoverLetter);
            return new CreateApplicationResult(result);
        }
    }
}
