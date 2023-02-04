using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("tp|teleport <Name> <Location>", Auth.Admin)]
public class TeleportLocationCommand : BaseCommand
{
    public string Name { get; set; }
    public string Location { get; set; }
}

[Command("tp|teleport <Name> <X> <Y> <Altitude>", Auth.Admin)]
public class TeleportCoordinatesCommand : BaseCommand
{
    public string Name { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Altitude { get; set; }
}