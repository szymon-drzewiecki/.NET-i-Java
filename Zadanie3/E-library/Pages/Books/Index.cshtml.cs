using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using E_library.Data;
using E_library.Models;

namespace E_library.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly E_library.Data.E_libraryContext _context;

        public IndexModel(E_library.Data.E_libraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
