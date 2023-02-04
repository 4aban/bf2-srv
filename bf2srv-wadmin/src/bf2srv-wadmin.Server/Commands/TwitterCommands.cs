using bf2srv-wadmin.Common;
using bf2srv-wadmin.Server.Abstractions;
using bf2srv-wadmin.Server.Extensions;

namespace bf2srv-wadmin.Server.Commands;

[Command("follow <Stream>", Auth.Trusted)]
public class TwitterFollowCommand : BaseCommand
{
    public string Stream { get; set; }
}

[Command("unfollow", Auth.Trusted)]
public class TwitterUnfollowCommand : BaseCommand
{
        
}