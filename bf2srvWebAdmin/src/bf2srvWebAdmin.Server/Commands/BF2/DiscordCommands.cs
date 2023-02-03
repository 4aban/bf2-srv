using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

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
