using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("blur <Name>", Auth.God)]
public class BlurCommand : BaseCommand
{
    public string Name { get; set; }
}