using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projecto_JaVi.Data;
using Projecto_JaVi.Models;

namespace Projecto_JaVi.Pages.Series
{
    public class CreateModel : PageModel
    {
        private readonly Projecto_JaVi.Data.Projecto_JaViContext _context;

        public CreateModel(Projecto_JaVi.Data.Projecto_JaViContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Serie Serie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Serie == null || Serie == null)
            {
                return Page();
            }

            _context.Serie.Add(Serie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
