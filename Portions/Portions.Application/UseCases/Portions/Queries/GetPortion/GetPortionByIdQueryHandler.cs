using Portions.Application.Abstractions.UseCases;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;

namespace Portions.Application.UseCases.Portions.Queries.GetPortion;

public class GetPortionByIdQueryHandler : IQueryHandler
{
    private IPortionsRepository _portionsRepo;
    private Guid _id;

    public GetPortionByIdQueryHandler(IPortionsRepository portionsRepo, Guid id)
    {
        _portionsRepo = portionsRepo;
        _id = id;
    }

    public async Task<Portion> Handle()
    {
        var portion = await _portionsRepo.GetPortionById(_id);

        if (portion is null)
        {
            return null;
        }

        return portion;
    }
}