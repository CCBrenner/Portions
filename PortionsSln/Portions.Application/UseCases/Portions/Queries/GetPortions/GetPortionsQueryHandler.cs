using Portions.Application.Abstractions.UseCases;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;

namespace Portions.Application.UseCases.Portions.Queries.GetPortions;

public class GetPortionsQueryHandler : IQueryHandler
{
    private readonly IPortionsRepository _portionsRepo;

    public GetPortionsQueryHandler(IPortionsRepository portionsRepo)
    {
        _portionsRepo = portionsRepo;
    }

    public async Task<List<Portion>> Handle(CancellationToken cancellationToken)
    {
        var portions = await _portionsRepo.GetPortions(cancellationToken);

        if (portions is null)
        {
            return null;
        }

        return portions;
    }
}