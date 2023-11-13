using MediatR;
using Zak.Shared.DTOs;

namespace Zak.Services.Interfaces;
public interface ISqauresServices
{
    public Task<List<SquareDTO>?> GetColoredSquaresAsync(int min, int max, IMediator mediator);
}