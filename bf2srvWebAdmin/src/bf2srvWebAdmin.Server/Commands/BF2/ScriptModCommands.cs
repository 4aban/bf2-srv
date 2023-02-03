using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("mod <Name> <Value>", Auth.God)]
public class ScriptModCommand : BaseCommand
{
    public string Name { get; set; }
    public string Value { get; set; }
}