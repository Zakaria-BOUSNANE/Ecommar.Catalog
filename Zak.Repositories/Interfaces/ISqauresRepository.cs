using Zak.Shared.DTOs;

namespace Zak.Repositories.Interfaces;
public interface ISqauresRepository
{
    public Task<List<SquareDTO>> GetColoredSquaresAsync(int min, int max);
}
