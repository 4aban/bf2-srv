using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("repair|heal", Auth.Admin)]
public class RepairAllCommand : BaseCommand
{
}

[Command("repair|heal <Name>", Auth.Admin)]
public class RepairCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("autorepair|autoheal", Auth.Admin)]
public class AutoRepairCommand : BaseCommand
{
}
