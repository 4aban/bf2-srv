using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

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
