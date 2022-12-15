using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projecto_JaVi.Data;
using Projecto_JaVi.Models;

namespace Projecto_JaVi.Pages.Series
{
    public class DeleteModel : PageModel
    {
        private readonly Projecto_JaVi.Data.Projecto_JaViContext _context;

        public DeleteModel(Projecto_JaVi.Data.Projecto_JaViContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Serie Serie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Serie == null)
            {
                return NotFound();
            }

            var serie = await _context.Serie.FirstOrDefaultAsync(m => m.Id == id);

            if (serie == null)
            {
                return NotFound();
            }
            else 
            {
                Serie = serie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Serie == null)
            {
                return NotFound();
            }
            var serie = await _context.Serie.FindAsync(id);

            if (serie != null)
            {
                Serie = serie;
                _context.Serie.Remove(Serie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
