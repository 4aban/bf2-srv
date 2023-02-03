using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("blur <Name>", Auth.God)]
public class BlurCommand : BaseCommand
{
    public string Name { get; set; }
}