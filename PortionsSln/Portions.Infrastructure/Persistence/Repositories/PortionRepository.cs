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

    public async Task<List<Portion>> GetPortions(CancellationToken cancellationToken)
    {
        return await _portionsDbContext.Portions.ToListAsync(cancellationToken);
    }

    public async Task<Portion?> GetPortionById(Guid id, CancellationToken cancellationToken)
    {
        return await _portionsDbContext.Portions.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<Guid?> AddPortion(Portion portion, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _portionsDbContext.Portions.AddAsync(portion, cancellationToken);

            if (result is null)
            {
                return null;
            }

            await _portionsDbContext.SaveChangesAsync();

            return portion.Id;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Inner Exception: \n{ex.InnerException}");

            return null;
        }
    }

    public async Task<Guid?> UpdatePortion(Portion portion, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void DeletePortion(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
