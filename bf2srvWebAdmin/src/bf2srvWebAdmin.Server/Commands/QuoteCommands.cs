using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("quote", Auth.All)]
public class QuoteCommand : BaseCommand
{
}

[Command("quote <Category>", Auth.All)]
public class QuoteCategoryCommand : BaseCommand
{
    public string Category { get; set; }
}