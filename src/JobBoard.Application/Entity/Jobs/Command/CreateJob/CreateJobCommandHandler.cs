using JobBoard.Application.Common.CQRS;
using JobBoard.Application.Common.Interfaces;
using JobBoard.Application.Entity.Jobs.Command.CreateJob;


namespace JobBoard.Application.Entity.Job.Command.CreateJob
{
    public class CreateJobCommandHandler : ICommandHandler<CreateJobCommand, CreateJobResult>
    {
        private readonly IJobRepository _jobRepository;
        public CreateJobCommandHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task<CreateJobResult> Handle(CreateJobCommand request, CancellationToken cancellationToken)
        {
            var result = await _jobRepository.AddAsync(request.Title, request.EmpoyerId, request.Description, request.Location, request.Salary);
            return new CreateJobResult(result.Id);
        }
    }
}
