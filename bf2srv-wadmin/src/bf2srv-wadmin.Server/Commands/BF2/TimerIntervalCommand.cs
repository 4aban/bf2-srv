using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("interval|timerinterval <Value>", Auth.Admin)]
public class TimerIntervalCommand : BaseCommand
{
    public double Value { get; set; }
}