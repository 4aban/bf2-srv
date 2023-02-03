namespace bf2srvWebAdmin.Shared.Communication.Events;

public class ServerRemoveEvent : IMessagePayload
{
    public string ServerId { get; set; }
}
