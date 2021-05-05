using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KursyWalut.Models;

namespace KursyWalut.Data
{
    public class KursyWalutContext : DbContext
    {
        public KursyWalutContext (DbContextOptions<KursyWalutContext> options)
            : base(options)
        {
        }

        public DbSet<KursyWalut.Models.Dane> Dane { get; set; }
    }
}
