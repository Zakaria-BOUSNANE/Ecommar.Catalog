using MediatR;
using Zak.Repositories.Interfaces;
using Zak.Shared.DTOs;
using Zak.Shared.Queries;

namespace Zak.Mediator;
public class GetSqauresQueryHandler : IRequestHandler<GetSqauresQuery, List<SquareDTO>?>
{
    private readonly ISqauresRepository _repository;
    public GetSqauresQueryHandler(ISqauresRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<SquareDTO>?> Handle(GetSqauresQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetColoredSquaresAsync(request.Min, request.Max);
    }
}