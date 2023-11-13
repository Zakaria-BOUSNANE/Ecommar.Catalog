using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zak.Services.Interfaces;
using Zak.Shared.DTOs;

namespace zak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SquaresController : ControllerBase
    {
        private readonly ISqauresServices _sqauresServices;        
        private readonly IMediator _mediator;

        public SquaresController(ISqauresServices sqauresServices, IMediator mediator)
        {
            _sqauresServices = sqauresServices;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<SquareDTO>>> GetColoredSquares(int min, int max)
        {
            var ColoredSquares = await _sqauresServices.GetColoredSquaresAsync(min,max, _mediator);

            if (ColoredSquares == null || !ColoredSquares.Any())
            {
                return NotFound();
            }
            return Ok(ColoredSquares);
        }
    }
}

