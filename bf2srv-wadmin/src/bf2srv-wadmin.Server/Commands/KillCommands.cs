using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("kill <Name>", Auth.Admin)]
public class KillCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("killid <PlayerId>", Auth.Admin)]
public class KillIdCommand : BaseCommand
{
    public int PlayerId { get; set; }
}