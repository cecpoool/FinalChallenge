using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ChallengeSem22019.Data;
using ChallengeSem22019.Models;

namespace ChallengeSem22019.Pages.SearchPayer
{
    public class IndexModel : PageModel
    {
        private readonly ChallengeSem22019.Data.ApplicationDbContext _context;

        public IndexModel(ChallengeSem22019.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var games = from g in _context.Games
                         select g;
            if (!string.IsNullOrEmpty(SearchString))
            {
                games = games.Where(g => g.Paid == true).Where(s => s.Payer.Contains(SearchString));
            }

            Game = await games.ToListAsync();
        }
    }
}
