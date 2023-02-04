namespace bf2srv-wadmin.Server.Abstractions;

public interface IHandleEventAsync<in TEvent> where TEvent : IEvent
{
    ValueTask HandleAsync(TEvent e);
}
