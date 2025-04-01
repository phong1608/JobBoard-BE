using FluentValidation;
using JobBoard.Application.Common.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobBoard.Application.Entity.Application.Command.CreateApplication
{
    public record CreateApplicationResult(Guid Id);
    public record CreateApplicationCommand(Guid JobId,Guid UserId, string CoverLetter ) :ICommand<CreateApplicationResult>;

    public class CreateApplicationValidator : AbstractValidator<CreateApplicationCommand>
    {
        public CreateApplicationValidator()
        {
            RuleFor(x => x.JobId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
    
}
