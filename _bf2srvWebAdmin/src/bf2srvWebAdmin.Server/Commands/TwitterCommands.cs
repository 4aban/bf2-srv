using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands;

[Command("follow <Stream>", Auth.Trusted)]
public class TwitterFollowCommand : BaseCommand
{
    public string Stream { get; set; }
}

[Command("unfollow", Auth.Trusted)]
public class TwitterUnfollowCommand : BaseCommand
{
        
}