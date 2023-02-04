using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("quote", Auth.All)]
public class QuoteCommand : BaseCommand
{
}

[Command("quote <Category>", Auth.All)]
public class QuoteCategoryCommand : BaseCommand
{
    public string Category { get; set; }
}