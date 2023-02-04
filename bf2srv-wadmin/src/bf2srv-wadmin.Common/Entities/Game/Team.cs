using System.Collections.Generic;

namespace bf2srv-wadmin.Common.Entities.Game;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<Player> Players { get; } = new List<Player>();
}