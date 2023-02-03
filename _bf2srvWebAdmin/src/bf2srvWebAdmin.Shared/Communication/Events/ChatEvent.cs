using bf2srvWebAdmin.Shared.Communication.DTOs;

namespace bf2srvWebAdmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class ChatEvent : IMessagePayload
{
    public MessageDto Message { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}