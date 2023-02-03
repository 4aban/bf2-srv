using bf2srvWebAdmin.Shared.Communication.DTOs;

namespace bf2srvWebAdmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class MapChangeEvent : IMessagePayload
{
    public string Map { get; set; }
    public int Size { get; set; }
    public int Index { get; set; }
    public IEnumerable<TeamDto> Teams { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}