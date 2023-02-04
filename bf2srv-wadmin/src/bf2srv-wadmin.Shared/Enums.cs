namespace bf2srv-wadmin.Shared;

public enum GameState
{
    PreGame,
    Playing,
    EndGame,
    Paused,
    Restart,
    NotConnected
}

public enum SocketState
{
    Connected,
    Disconnected
}
