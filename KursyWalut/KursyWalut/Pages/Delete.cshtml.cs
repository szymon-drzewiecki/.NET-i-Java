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
    public class DeleteModel : PageModel
    {
        private readonly KursyWalut.Data.KursyWalutContext _context;

        public DeleteModel(KursyWalut.Data.KursyWalutContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dane = await _context.Dane.FindAsync(id);

            if (Dane != null)
            {
                _context.Dane.Remove(Dane);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
