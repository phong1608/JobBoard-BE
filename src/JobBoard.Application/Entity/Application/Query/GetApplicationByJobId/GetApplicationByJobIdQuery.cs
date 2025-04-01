using JobBoard.Application.Common.CQRS;
using JobBoard.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Application.Entity.Application.Query.GetApplicationByJobId
{
    public record GetApplicationByJobIdResult(List<ApplicationDTO> Applications);
    public record GetApplicationByJobIdQuery(Guid JobId):IQuery<GetApplicationByJobIdResult>;
    
}
