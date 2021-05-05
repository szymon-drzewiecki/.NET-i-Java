using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KursyWalut.Data;
using KursyWalut.Models;

namespace KursyWalut.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly KursyWalut.Data.KursyWalutContext _context;

        public DetailsModel(KursyWalut.Data.KursyWalutContext context)
        {
            _context = context;
        }

        public Dane Dane { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dane = await _context.Dane.FirstOrDefaultAsync(m => m.ID == id);

            if (Dane == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
