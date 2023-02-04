using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands.BF2;

[Command("leave <Minutes>", Auth.All)]
public class LeaveCommand : BaseCommand
{
    public int Minutes { get; set; }
}

[Command("calladmin <Reason>", Auth.All)]
public class CallAdminCommand : BaseCommand
{
    public string Reason { get; set; }
}
