using bf2srvWebAdmin.Common.Entities.Game;

namespace bf2srvWebAdmin.Server.Abstractions;

public abstract class BaseCommand : ICommand
{
    public Message Message { get; set; }
}