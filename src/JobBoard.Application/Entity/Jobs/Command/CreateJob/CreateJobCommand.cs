
using FluentValidation;
using JobBoard.Application.Common.CQRS;

namespace JobBoard.Application.Entity.Jobs.Command.CreateJob
{
    public record CreateJobResult(Guid Id);
    public record CreateJobCommand(string Title, string EmpoyerId, string Description, string Location, float Salary):ICommand<CreateJobResult>;
    public class CreateJobCommandValidator:AbstractValidator<CreateJobCommand>
    {
        public CreateJobCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Yêu cầu tiêu đề");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Yêu cầu mô tả");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Yêu cầu địa chỉ");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Yêu cầu mức lương");
        }
    }
    
}
