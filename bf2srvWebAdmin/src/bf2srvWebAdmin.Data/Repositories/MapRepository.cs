using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bf2srvWebAdmin.Data.Abstractions;
using bf2srvWebAdmin.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace bf2srvWebAdmin.Data.Repositories;

public class MapRepository : IMapRepository
{
    private readonly BF2Context _context;

    public MapRepository(BF2Context context)
    {
        _context = context;
    }

    public async Task<IEnumerable<MapMod>> GetAsync()
    {
        return await _context.MapMods.ToListAsync();
    }

    public async Task<MapMod> GetAsync(Guid id)
    {
        return await _context.MapMods
            .Include(mm => mm.MapModObjects)
            .FirstOrDefaultAsync(mm => mm.Id == id);
    }

    public async Task CreateAsync(MapMod map)
    {
        await _context.MapMods.AddAsync(map);
    }

    public async Task UpdateAsync(MapMod map)
    {
        _context.MapMods.Update(map);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        _context.MapMods.Remove(new MapMod {Id = id });
        await _context.SaveChangesAsync();
    }
}