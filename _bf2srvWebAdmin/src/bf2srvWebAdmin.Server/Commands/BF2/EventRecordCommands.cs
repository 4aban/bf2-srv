using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("starteventrecorder", Auth.God)]
public class StartEventRecordingCommand : BaseCommand
{
}

[Command("stopeventrecorder", Auth.God)]
public class StopEventRecordingCommand : BaseCommand
{
}
