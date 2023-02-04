using bf2srv-wadmin.Shared.Communication.DTOs;

namespace bf2srv-wadmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class PlayerJoinEvent : IMessagePayload
{
    public PlayerDto Player { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}