using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("g|gravity", Auth.Admin)]
public class GravityDefaultCommand : BaseCommand
{
}

[Command("g|gravity <Value>", Auth.Admin)]
public class GravityCommand : BaseCommand
{
    public double Value { get; set; }
}