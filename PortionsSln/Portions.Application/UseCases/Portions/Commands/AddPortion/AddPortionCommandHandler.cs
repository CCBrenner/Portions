using Portions.Application.Abstractions.UseCases;
using Portions.Application.DtoModels;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;

namespace Portions.Application.UseCases.Portions.Commands.AddPortion;

public class AddPortionCommandHandler : ICommandHandler
{
    private readonly IPortionsRepository _portionsRepo;

    public AddPortionCommandHandler(IPortionsRepository portionsRepo)
    {
        _portionsRepo = portionsRepo;
    }

    public async Task<Guid?> Handle(PortionAddDto portionAddDto, CancellationToken cancellationToken)
    {
        var portion = Portion.Create(
            portionAddDto.Id,
            portionAddDto.CreatedDate,
            portionAddDto.LastModifiedDate,
            portionAddDto.VerseText);

        var portions = await _portionsRepo.AddPortion(portion, cancellationToken);

        if (portions is null)
        {
            return null;
        }

        return portions;
    }
}
