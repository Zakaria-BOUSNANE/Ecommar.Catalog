using Zak.Repositories.Interfaces;
using Zak.Shared.DTOs;

namespace Zak.Repositories;
public class SqauresRepository : ISqauresRepository
{
    public async Task<List<SquareDTO>> GetColoredSquaresAsync(int min, int max)
    {
        try
        {
            var squares = new List<SquareDTO>();

            await Task.Run(() =>
            {
                for (int i = min; i <= max; i++)
                {
                    string color = "red";

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        color = "yellow";
                    }
                    else if (i % 3 == 0)
                    {
                        color = "green";
                    }
                    else if (i % 5 == 0)
                    {
                        color = "blue";
                    }

                    var squareDto = new SquareDTO(i, color);
                    squares.Add(squareDto);
                }
            });
            return squares;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}
