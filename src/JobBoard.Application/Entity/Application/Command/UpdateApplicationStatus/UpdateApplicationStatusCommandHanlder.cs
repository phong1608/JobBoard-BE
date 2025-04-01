using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Application.Command.UpdateApplicationStatus
{
    internal class UpdateApplicationStatusCommandHanlder : ICommandHandler<UpdateApplicationStatusCommand, UpdateApplicationStatusResult>
    {
        private readonly IApplicationRepository _applicationRepository;
        public UpdateApplicationStatusCommandHanlder(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<UpdateApplicationStatusResult> Handle(UpdateApplicationStatusCommand request, CancellationToken cancellationToken)
        {
            var result = await _applicationRepository.UpdateApplicationStatus(request.Id, request.Status);
            return new UpdateApplicationStatusResult(result);
        }
    }
}
