namespace bf2srvWebAdmin.Server.Abstractions;

public interface IHandleCommand<in TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}