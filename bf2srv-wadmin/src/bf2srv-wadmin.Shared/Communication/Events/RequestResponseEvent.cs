namespace bf2srv-wadmin.Shared.Communication.Events;

public class RequestResponseEvent : IMessagePayload
{
    public string Request { get; set; }
    public string Response { get; set; }
}
