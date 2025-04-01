using JobBoard.Application.Common.CQRS;


namespace JobBoard.Application.Entity.User.Commands.Login
{
    public record LoginResult(string Token);
    public record LoginCommand(string Email,string Password) :ICommand<LoginResult>;
}
