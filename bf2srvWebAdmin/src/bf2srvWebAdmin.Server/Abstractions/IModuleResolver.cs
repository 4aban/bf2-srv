using bf2srvWebAdmin.Common;

namespace bf2srvWebAdmin.Server.Abstractions;

public interface IModuleResolver
{
    IDictionary<string, IList<Func<string[], ICommand>>> CommandParsers { get; }
    //IDictionary<Type, IList<Action<ICommand>>> CommandHandlers { get; }
    IDictionary<Type, IList<Func<ICommand, ValueTask>>> CommandHandlers { get; }
    IDictionary<Type, IList<Func<IEvent, ValueTask>>> EventHandlers { get; }
    IDictionary<Type, Auth> AuthLevels { get; }
    IEnumerable<Type> ModuleTypes { get; }
    IDictionary<Type, IModule> Modules { get; }
}
