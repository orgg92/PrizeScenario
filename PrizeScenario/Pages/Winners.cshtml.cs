using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PrizeScenario.Models;
using PrizeScenario.Services;


namespace PrizeScenario.Pages
{
    public class WinnersModel : PageModel
    {
        private readonly IDrawService _drawService;
        public List<Participant> Participants;

        public WinnersModel(IDrawService drawService)
        {
            _drawService = drawService;
        }

        public async Task OnGet(int count)
        {
            
            Participants = await _drawService.DrawWinners(count);

            // because the db seed size is so small, we're bound to get duplicates the higher 'count' but in practise I imagine this would be less noticable 
            // i would probably consider writing another method with Participants as a parameter and then find records where UserId != any entries of the list to build up the list to the desired size

            // remove any duplicates
            Participants = Participants.Distinct().ToList();
        }
    }
}
