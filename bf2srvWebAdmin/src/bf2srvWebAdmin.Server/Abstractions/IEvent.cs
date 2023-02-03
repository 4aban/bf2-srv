namespace bf2srvWebAdmin.Server.Abstractions;

public interface IEvent
{
    DateTimeOffset TimeStamp { get; }
}
