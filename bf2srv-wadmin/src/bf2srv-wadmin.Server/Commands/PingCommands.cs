using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("ping", Auth.All)]
public class PingSelfCommand : BaseCommand
{
        
}

[Command("ping <Name>", Auth.All)]
public class PingCommand : BaseCommand
{
    public string Name { get; set; }
}