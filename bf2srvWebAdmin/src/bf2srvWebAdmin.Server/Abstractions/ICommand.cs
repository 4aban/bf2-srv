using bf2srvWebAdmin.Common.Entities.Game;

namespace bf2srvWebAdmin.Server.Abstractions;

public interface ICommand
{
    Message Message{ get; }
}