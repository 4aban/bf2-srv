using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("interval|timerinterval <Value>", Auth.Admin)]
public class TimerIntervalCommand : BaseCommand
{
    public double Value { get; set; }
}