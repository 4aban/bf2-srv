using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

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