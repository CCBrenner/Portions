using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portions.Application.UseCases.Portions.Queries.GetPortions;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;
using Portions.Application.UseCases.Portions.Queries.GetPortion;
using Portions.Infrastructure.Extensions;
using Portions.Application.UseCases.Portions.Commands.AddPortion;
using Portions.Application.DtoModels;

namespace Portions.Presentation.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class PortionsController : ControllerBase
{
    private readonly IPortionsRepository _portionsRepo;

    public PortionsController(IPortionsRepository portionsRepo)
    {
       _portionsRepo = portionsRepo;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PortionDto>>> GetPortions(CancellationToken cancellationToken)
    {
        try
        {
            var handler = new GetPortionsQueryHandler(_portionsRepo);

            var portions = await handler.Handle(cancellationToken);

            if (portions is null)
            {
                return NotFound();
            }

            var portionDtos = portions.ConvertToDto();

            return Ok(portionDtos);
        }
        catch (TaskCanceledException)
        {
            return BadRequest("Operation was cancelled.");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error retrieving data from the database:\n{ex.Message}");
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Portion>> GetPortionById(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var handler = new GetPortionByIdQueryHandler(_portionsRepo, id);

            var portion = await handler.Handle(cancellationToken);

            if (portion is null) return NotFound();

            var portionDto = portion.ConvertToDto();

            return Ok(portion);
        }
        catch (TaskCanceledException)
        {
            return BadRequest("Operation was cancelled.");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error retrieving data from the database:\n{ex.Message}");
        }
    }
    [HttpPost]
    public async Task<ActionResult<Guid>> AddPortion(PortionAddDto portionAddDto, CancellationToken cancellationToken)
    {
        try
        {
            var handler = new AddPortionCommandHandler(_portionsRepo);

            var result = await handler.Handle(portionAddDto, cancellationToken);

            if (result is null)
            {
                return NoContent();
            }

            return Ok(result);
        }
        catch (TaskCanceledException)
        {
            return BadRequest("Operation was cancelled.");
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}