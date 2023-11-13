using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zak.Repositories.Interfaces;
using Zak.Shared.DTOs;

namespace Zak.Repositories
{
    public class SqauresRepository : ISqauresRepository
    {
        public async Task<List<SquareDTO>> GetColoredSquaresAsync(int min, int max)
        {
            var squares = new List<SquareDTO>();

            await Task.Run(() =>
            {
                for (int i = min; i <= max; i++)
                {
                    string color = "red"; // Default color if the number is neither divisible by 3 nor by 5.

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
                    //var new square here 

                    squares.Add(new SquareDTO(i, color));
                }
            });

            return squares;
        }



    }
}
