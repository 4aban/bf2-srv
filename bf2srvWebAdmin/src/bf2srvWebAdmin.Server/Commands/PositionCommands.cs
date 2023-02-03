using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("p|position", Auth.Trusted)]
public class PositionSelfCommand : BaseCommand
{
}

[Command("p|position <Name>", Auth.Trusted)]
public class PositionCommand : BaseCommand
{
    public string Name { get; set; }
}