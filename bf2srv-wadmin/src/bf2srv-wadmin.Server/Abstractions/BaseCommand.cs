using bf2srv-wadmin.Common.Entities.Game;

namespace bf2srv-wadmin.Server.Abstractions;

public abstract class BaseCommand : ICommand
{
    public Message Message { get; set; }
}