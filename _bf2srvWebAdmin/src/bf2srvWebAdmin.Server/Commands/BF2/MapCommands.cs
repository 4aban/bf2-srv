using bf2srvWebAdmin.Common;
using bf2srvWebAdmin.Server.Abstractions;
using bf2srvWebAdmin.Server.Extensions;

namespace bf2srvWebAdmin.Server.Commands.BF2;

[Command("load|mapload <Name>", Auth.Admin)]
public class MapLoadCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("save|mapsave <Name>", Auth.Admin)]
public class MapSaveCommand : BaseCommand
{
    public string Name { get; set; }
}

[Command("o|mapobject <Template>", Auth.Admin)]
public class MapObjectCommand : BaseCommand
{
    public string Template { get; set; }
}

[Command("clear|mapclear", Auth.Admin)]
public class MapClearCommand : BaseCommand
{
}

[Command("undo|mapundo <Count>", Auth.Admin)]
public class MapUndoCommand : BaseCommand
{
    public int Count { get; set; }
}