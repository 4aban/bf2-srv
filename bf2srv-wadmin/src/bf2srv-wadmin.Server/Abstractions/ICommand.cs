using bf2srv-wadmin.Common.Entities.Game;

namespace bf2srv-wadmin.Server.Abstractions;

public interface ICommand
{
    Message Message{ get; }
}