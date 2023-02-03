using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

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