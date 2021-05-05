using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KursyWalut.Data;
using KursyWalut.Models;

namespace KursyWalut.Pages
{
    public class EditModel : PageModel
    {
        private readonly KursyWalut.Data.KursyWalutContext _context;

        public EditModel(KursyWalut.Data.KursyWalutContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dane).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DaneExists(Dane.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DaneExists(int id)
        {
            return _context.Dane.Any(e => e.ID == id);
        }
    }
}
