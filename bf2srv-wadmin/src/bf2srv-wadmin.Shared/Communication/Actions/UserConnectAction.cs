namespace bf2srv-wadmin.Shared.Communication.Actions;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class UserConnectAction : IMessagePayload
{
    public string Id { get; set; }
}