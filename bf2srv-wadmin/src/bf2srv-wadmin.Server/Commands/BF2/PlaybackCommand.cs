using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

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