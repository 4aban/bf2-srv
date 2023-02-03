using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("record", Auth.Admin)]
public class RecordCommand : BaseCommand
{
}

[Command("playback", Auth.Admin)]
public class PlaybackCommand : BaseCommand
{
}

[Command("loop", Auth.Admin)]
public class LoopCommand : BaseCommand
{
}