using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("g|gravity", Auth.Admin)]
public class GravityDefaultCommand : BaseCommand
{
}

[Command("g|gravity <Value>", Auth.Admin)]
public class GravityCommand : BaseCommand
{
    public double Value { get; set; }
}