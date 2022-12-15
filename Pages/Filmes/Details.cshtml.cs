using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projecto_JaVi.Data;
using Projecto_JaVi.Models;

namespace Projecto_JaVi.Pages.Filmes
{
    public class DetailsModel : PageModel
    {
        private readonly Projecto_JaVi.Data.Projecto_JaViContext _context;

        public DetailsModel(Projecto_JaVi.Data.Projecto_JaViContext context)
        {
            _context = context;
        }

      public Filme Filme { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FirstOrDefaultAsync(m => m.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            else 
            {
                Filme = filme;
            }
            return Page();
        }
    }
}
