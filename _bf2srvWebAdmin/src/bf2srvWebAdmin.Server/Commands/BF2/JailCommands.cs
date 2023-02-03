using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("jail <Name>", Auth.Admin)]
public class JailPlayerCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("free <Name>", Auth.Admin)]
public class FreePlayerCommand : BaseCommand
{
    public string Name { get; set; }
}
