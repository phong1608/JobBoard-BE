using FluentValidation;
using JobBoard.Application.Common.CQRS;


namespace JobBoard.Application.Entity.Jobs.Command.UpdateJob
{
    public record UpdateJobResult(bool IsUpdated);
    public record UpdateJobCommand(string Title, string EmpoyerId, string Description, string Location, float Salary):ICommand<UpdateJobResult>;
    public class UpdateJobValidator : AbstractValidator<UpdateJobCommand>
    {
        public UpdateJobValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Yêu cầu tiêu đề");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Yêu cầu mô tả");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Yêu cầu địa chỉ");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Yêu cầu mức lương");
        }
    }
}
