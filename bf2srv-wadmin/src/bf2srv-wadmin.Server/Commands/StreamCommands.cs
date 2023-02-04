using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("startstream", Auth.God)]
public class StartStreamCommand : BaseCommand
{
}

[Command("stopstream|kickbot", Auth.God)]
public class StopStreamCommand : BaseCommand
{
}
