﻿namespace bf2srvWebAdmin.Data;

public class DatabaseConfig
{
    public ConnectionStrings ConnectionStrings { get; set; }
}

public class ConnectionStrings
{
    public string BF2DB { get; set; }
}