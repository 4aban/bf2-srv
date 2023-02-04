using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("freeze", Auth.God)]
public class FreezeAllCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("freeze <Name>", Auth.God)]
public class FreezeCommand : BaseCommand
{
    public string Name { get; set; }
}