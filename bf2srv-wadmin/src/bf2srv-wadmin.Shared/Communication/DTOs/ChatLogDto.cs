namespace bf2srv-wadmin.Shared.Communication.DTOs;

public class ChatLogDto
{
    public MessageDto Message { get; set; }
    public DateTimeOffset Timestamp { get; set; }
}
