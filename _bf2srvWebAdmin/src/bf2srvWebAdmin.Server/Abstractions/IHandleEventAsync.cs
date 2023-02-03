namespace bf2srvWebAdmin.Server.Abstractions;

public interface IHandleEventAsync<in TEvent> where TEvent : IEvent
{
    ValueTask HandleAsync(TEvent e);
}
