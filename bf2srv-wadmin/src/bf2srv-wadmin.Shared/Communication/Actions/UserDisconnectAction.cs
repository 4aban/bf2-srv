namespace bf2srv-wadmin.Shared.Communication.Actions;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class UserDisconnectAction : IMessagePayload
{
    public string Id { get; set; }
}