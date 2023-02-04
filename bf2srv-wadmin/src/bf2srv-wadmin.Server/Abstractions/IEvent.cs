namespace bf2srv-wadmin.Server.Abstractions;

public interface IEvent
{
    DateTimeOffset TimeStamp { get; }
}
