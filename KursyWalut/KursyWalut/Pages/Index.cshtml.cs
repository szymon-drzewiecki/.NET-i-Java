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
    public class IndexModel : PageModel
    {
        private readonly KursyWalut.Data.KursyWalutContext _context;

        public IndexModel(KursyWalut.Data.KursyWalutContext context)
        {
            _context = context;
        }

        public IList<Dane> Dane { get;set; }

        public async Task OnGetAsync()
        {
            Dane = await _context.Dane.ToListAsync();
        }
    }
}
