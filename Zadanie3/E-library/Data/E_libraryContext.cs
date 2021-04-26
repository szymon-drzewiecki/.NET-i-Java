using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_library.Models;

namespace E_library.Data
{
    public class E_libraryContext : DbContext
    {
        public E_libraryContext (DbContextOptions<E_libraryContext> options)
            : base(options)
        {
        }

        public DbSet<E_library.Models.Book> Book { get; set; }
    }
}
