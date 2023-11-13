using MediatR;
using Zak.Shared.DTOs;

namespace Zak.Shared.Queries;
public class GetSqauresQuery : IRequest<List<SquareDTO>?>
{
    public int Min { get; set; }
    public int Max { get; set; }
    public GetSqauresQuery(int min, int max)
    {
        Min = min;
        Max = max;
    }
}