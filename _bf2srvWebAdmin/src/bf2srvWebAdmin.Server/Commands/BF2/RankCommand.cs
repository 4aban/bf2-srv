using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("r|rank <Name> <Rank>", Auth.Admin)]
public class RankCommand : BaseCommand
{
    public string Name { get; set; }
    public int Rank { get; set; }
}