namespace bf2srv-wadmin.Shared.Communication.Events;

public class ServerRemoveEvent : IMessagePayload
{
    public string ServerId { get; set; }
}
