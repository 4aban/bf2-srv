using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

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