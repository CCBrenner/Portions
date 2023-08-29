using Microsoft.EntityFrameworkCore;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;
using Portions.Infrastructure.Persistence;

namespace Portions.Domain.Abstractions;

public class PortionsRepository : IPortionsRepository
{
    private readonly PortionsDbContext _portionsDbContext;

    public PortionsRepository(PortionsDbContext portionsDbContext)
    {
        _portionsDbContext = portionsDbContext;
    }

    public async Task<List<Portion>> GetPortions()
    {
        return await _portionsDbContext.Portions.ToListAsync();
    }

    public async Task<Portion?> GetPortionById(Guid id)
    {
        return await _portionsDbContext.Portions.FirstOrDefaultAsync(x => x.Id == id);
    }

    public void AddPortion(Guid id)
    {
        throw new NotImplementedException();
    }

    public void DeletePortion(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Portion> GetPortionById()
    {
        throw new NotImplementedException();
    }
}
