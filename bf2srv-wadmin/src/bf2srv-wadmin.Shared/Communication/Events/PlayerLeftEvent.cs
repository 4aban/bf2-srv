﻿namespace bf2srv-wadmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class PlayerLeftEvent : IMessagePayload
{
    public int PlayerId { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}