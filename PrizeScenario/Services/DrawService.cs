using Microsoft.EntityFrameworkCore;
using PrizeScenario.Data;
using PrizeScenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace PrizeScenario.Services
{
    public class DrawService : IDrawService
    {
        private readonly DrawContext _drawContext;

        private List<Participant> winners;
        private List<int> randoms;

        public DrawService(DrawContext drawContext)
        {
            _drawContext = drawContext;
            winners = new List<Participant>();
            randoms = new List<int>();
        }

        public async Task<List<Participant>> DrawWinners(int count)
        {

            // I thought here I would use a random number generator to populate a list of 10 winners and return their user IDs and then iterate the list for 
            // participants where userId == integer in that element of the list

            randoms = GenerateWinners(count);

            for (int i = 0; i < count; i++)
            {
                winners.Add(await _drawContext.Participants.Where(x => x.UserId == randoms[i]).FirstOrDefaultAsync());
            }


            return winners;
        }

        private List<int> GenerateWinners(int count)
        {
            int entries = _drawContext.Participants.Count();
            Random r = new Random();
            int n = r.Next(1, entries);

            for (int i = 0; i < count; i++)
            {
                
                randoms.Add(n);
                n = r.Next(1, entries);
            }

            return randoms;
        }
    }
}
