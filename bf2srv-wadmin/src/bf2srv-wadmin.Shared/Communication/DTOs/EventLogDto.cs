﻿namespace bf2srv-wadmin.Shared.Communication.DTOs;

public class EventLogDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Message { get; set; }
    public DateTimeOffset Timestamp { get; set; }
}
