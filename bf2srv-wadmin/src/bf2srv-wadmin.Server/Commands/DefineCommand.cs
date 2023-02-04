using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("define <Term>", Auth.All)]
public class DefineCommand : BaseCommand
{
    public string Term { get; set; }
}