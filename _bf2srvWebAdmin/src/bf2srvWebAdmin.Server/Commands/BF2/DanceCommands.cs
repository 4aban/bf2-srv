using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("d|dance", Auth.Admin)]
public class DanceAllCommand : BaseCommand
{
}

[Command("d|dance <Name>", Auth.Admin)]
public class DanceCommand : BaseCommand
{
    public string Name { get; set; }
}