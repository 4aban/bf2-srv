namespace bf2srvWebAdmin.Shared.Communication.DTOs;

public class ChatLogDto
{
    public MessageDto Message { get; set; }
    public DateTimeOffset Timestamp { get; set; }
}
