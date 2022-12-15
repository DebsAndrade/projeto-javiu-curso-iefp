using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projecto_JaVi.Data;
using Projecto_JaVi.Models;

namespace Projecto_JaVi.Pages.Contactos
{
    public class DetailsModel : PageModel
    {
        private readonly Projecto_JaVi.Data.Projecto_JaViContext _context;

        public DetailsModel(Projecto_JaVi.Data.Projecto_JaViContext context)
        {
            _context = context;
        }

      public Contacto Contacto { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Contacto == null)
            {
                return NotFound();
            }

            var contacto = await _context.Contacto.FirstOrDefaultAsync(m => m.Id == id);
            if (contacto == null)
            {
                return NotFound();
            }
            else 
            {
                Contacto = contacto;
            }
            return Page();
        }
    }
}
