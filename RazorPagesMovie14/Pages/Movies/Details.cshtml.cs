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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie14.Data.RazorPagesMovie14Context _context;

        public DetailsModel(RazorPagesMovie14.Data.RazorPagesMovie14Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
