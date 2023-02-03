using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("define <Term>", Auth.All)]
public class DefineCommand : BaseCommand
{
    public string Term { get; set; }
}