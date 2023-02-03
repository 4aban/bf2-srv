﻿using bf2srvWebAdmin.Shared.Communication.DTOs;

namespace bf2srvWebAdmin.Shared.Communication.Events;

//[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
//[MessagePackObject(keyAsPropertyName: true)]
public class PlayerPositionEvent : IMessagePayload
{
    public int PlayerId { get; set; }
    public Vector3 Position { get; set; }
    public Vector3 Rotation { get; set; }
    public int Ping { get; set; }
    public DateTimeOffset TimeStamp { get; set; }
}