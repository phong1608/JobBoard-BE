using JobBoard.Application.Common.CQRS;
using JobBoard.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobBoard.Application.Entity.Application.Command.UpdateApplicationStatus
{
    public record UpdateApplicationStatusResult(bool IsUpdated);
    public record UpdateApplicationStatusCommand(Guid Id, ApplicationStatus Status):ICommand<UpdateApplicationStatusResult>;
    
}
