using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

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
