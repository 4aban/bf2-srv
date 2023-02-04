using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("r|rank <Name> <Rank>", Auth.Admin)]
public class RankCommand : BaseCommand
{
    public string Name { get; set; }
    public int Rank { get; set; }
}