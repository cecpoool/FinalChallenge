using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChallengeSem22019.Data;
using ChallengeSem22019.Models;

namespace ChallengeSem22019.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly ChallengeSem22019.Data.ApplicationDbContext _context;

        public IndexModel(ChallengeSem22019.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get; set; }

        public async Task OnGetAsync()
        {

            Game = await _context.Games.ToListAsync();
        }
    }
}

