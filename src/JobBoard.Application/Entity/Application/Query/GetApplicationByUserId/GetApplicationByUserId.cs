using JobBoard.Application.Common.CQRS;
using JobBoard.Application.DTOs;


namespace JobBoard.Application.Entity.Application.Query.GetApplicationByUserId
{
    public record GetApplicationByUserIdResult(List<ApplicationDTO> Applications);
    public record GetApplicationByUserId(Guid UserId):IQuery<GetApplicationByUserIdResult>;
    
}
