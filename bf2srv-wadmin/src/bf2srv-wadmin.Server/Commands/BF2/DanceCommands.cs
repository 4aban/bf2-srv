using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("d|dance", Auth.Admin)]
public class DanceAllCommand : BaseCommand
{
}

[Command("d|dance <Name>", Auth.Admin)]
public class DanceCommand : BaseCommand
{
    public string Name { get; set; }
}