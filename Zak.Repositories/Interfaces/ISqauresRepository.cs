using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zak.Shared.DTOs;

namespace Zak.Repositories.Interfaces
{
    public interface ISqauresRepository
    {
       public Task<List<SquareDTO>> GetColoredSquaresAsync(int min, int max);

    }
}
