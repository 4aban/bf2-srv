using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("flip <Name>", Auth.Admin)]
public class FlipCommand : BaseCommand
{
    public string Name { get; set; }
}