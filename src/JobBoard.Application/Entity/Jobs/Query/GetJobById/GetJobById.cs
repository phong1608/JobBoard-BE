using JobBoard.Application.Common.CQRS;


namespace JobBoard.Application.Entity.Jobs.Query.GetJobById
{
    public record GetJobByIdResult(JobBoard.Domain.Models.Job Job);
    public record GetJobById(Guid Id):IQuery<GetJobByIdResult>;
    
}
