using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("starteventrecorder", Auth.God)]
public class StartEventRecordingCommand : BaseCommand
{
}

[Command("stopeventrecorder", Auth.God)]
public class StopEventRecordingCommand : BaseCommand
{
}
