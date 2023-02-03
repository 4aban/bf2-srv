using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("ping", Auth.All)]
public class PingSelfCommand : BaseCommand
{
        
}

[Command("ping <Name>", Auth.All)]
public class PingCommand : BaseCommand
{
    public string Name { get; set; }
}