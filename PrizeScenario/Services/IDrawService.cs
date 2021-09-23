using PrizeScenario.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrizeScenario.Services
{
    public interface IDrawService
    {
        Task<List<Participant>> DrawWinners(int count);
    }
}