using JobBoard.Application.Common.CQRS;
using JobBoard.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Job.Query.GetJobByUserId
{
    public record GetJobByUserIdResult(List<JobDTO> Jobs);
    
    public record GetJobByUserIdQuery(Guid UserId):IQuery<GetJobByUserIdResult>;
    
}
