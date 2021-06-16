using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie14.Data;
using RazorPagesMovie14.Models;

namespace RazorPagesMovie14.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie14.Data.RazorPagesMovie14Context _context;

        public IndexModel(RazorPagesMovie14.Data.RazorPagesMovie14Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
