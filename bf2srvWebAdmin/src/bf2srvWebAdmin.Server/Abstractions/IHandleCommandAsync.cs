namespace bf2srvWebAdmin.Server.Abstractions;

public interface IHandleCommandAsync<in TCommand> where TCommand : ICommand
{
    ValueTask HandleAsync(TCommand command);
}