﻿namespace bf2srvWebAdmin.Server.Abstractions;

public interface IGameReader
{
    //Task ParseMessageAsync(string message);
    void QueueMessage(string message);
    void StartRecording(string gameLogPath);
    void StopRecording();
}
