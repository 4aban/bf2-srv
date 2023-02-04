using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("p|position", Auth.Trusted)]
public class PositionSelfCommand : BaseCommand
{
}

[Command("p|position <Name>", Auth.Trusted)]
public class PositionCommand : BaseCommand
{
    public string Name { get; set; }
}