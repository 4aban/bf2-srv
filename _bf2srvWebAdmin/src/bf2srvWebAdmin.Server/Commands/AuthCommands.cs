using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("auth <Name> <Level>", Auth.Admin)]
public class SetAuthCommand : BaseCommand
{
    public string Name { get; set; }
    public int Level { get; set; }
}

[Command("auth <Name>", Auth.Admin)]
public class GetAuthCommand : BaseCommand
{
    public string Name { get; set; }
}