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
    public class IndexModel : PageModel
    {
        private readonly Projecto_JaVi.Data.Projecto_JaViContext _context;

        public IndexModel(Projecto_JaVi.Data.Projecto_JaViContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Filme != null)
            {
                Filme = await _context.Filme.ToListAsync();
            }
        }
    }
}
