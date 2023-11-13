using MediatR;
using Zak.Services.Interfaces;
using Zak.Shared.DTOs;
using Zak.Shared.Queries;

namespace Zak.Services;
public class SqauresServices : ISqauresServices
{
    public async Task<List<SquareDTO>?> GetColoredSquaresAsync(int min, int max, IMediator mediator)
    {
        try
        {
            var command = new GetSqauresQuery(min, max);
            return await mediator.Send(command);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}