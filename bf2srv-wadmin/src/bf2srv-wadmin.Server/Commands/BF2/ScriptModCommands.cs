using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("mod <Name> <Value>", Auth.God)]
public class ScriptModCommand : BaseCommand
{
    public string Name { get; set; }
    public string Value { get; set; }
}