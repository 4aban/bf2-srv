using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("startstream", Auth.God)]
public class StartStreamCommand : BaseCommand
{
}

[Command("stopstream|kickbot", Auth.God)]
public class StopStreamCommand : BaseCommand
{
}
