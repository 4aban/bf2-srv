using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bf2srv-wadmin.Data.Entities;

namespace bf2srv-wadmin.Data.Abstractions;

public interface IMatchRepository
{
    Task<Match> GetMatchAsync(Guid matchId);
    Task<IEnumerable<Match>> GetMatchesByNewestAsync(int offset, int numberOfRows);
    Task InsertMatchAsync(Match match);
    Task UpdateMatchAsync(Match match);
    Task InsertRoundAsync(MatchRound round);
}