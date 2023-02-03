using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("flip <Name>", Auth.Admin)]
public class FlipCommand : BaseCommand
{
    public string Name { get; set; }
}