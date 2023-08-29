﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portions.Application.UseCases.Portions.Queries.GetPortions;
using Portions.Domain.Abstractions.Repositories;
using Portions.Domain.Entities;
using Portions.Infrastructure.Dtos.Models;
using Portions.Infrastructure.Dtos;
using Portions.Application.UseCases.Portions.Queries.GetPortion;

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
    public async Task<ActionResult<IEnumerable<PortionDto>>> GetPortions()
    {
        try
        {
            var handler = new GetPortionsQueryHandler(_portionsRepo);

            var portions = await handler.Handle();

            if (portions is null)
            {
                return NotFound();
            }

            var portionDtos = portions.ConvertToDto();

            return Ok(portionDtos);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error retrieving data from the database:\n{ex.Message}");
        }
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Portion>> GetPortionById(Guid id)
    {
        try
        {
            var handler = new GetPortionByIdQueryHandler(_portionsRepo, id);

            var portion = await handler.Handle();

            if (portion is null)
            {
                return NotFound();
            }

            var portionDto = portion.ConvertToDto();

            return Ok(portion);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                $"Error retrieving data from the database:\n{ex.Message}");
        }
    }
}