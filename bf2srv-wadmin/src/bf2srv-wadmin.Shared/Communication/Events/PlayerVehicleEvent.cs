using bf2srv-wadmin.Shared.Communication.DTOs;

namespace bf2srv-wadmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class PlayerVehicleEvent : IMessagePayload
{
    public int PlayerId { get; set; }
    public VehicleDto Vehicle { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}