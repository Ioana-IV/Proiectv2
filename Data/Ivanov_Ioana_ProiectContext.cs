#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Data
{
    public class Ivanov_Ioana_ProiectContext : DbContext
    {
        public Ivanov_Ioana_ProiectContext (DbContextOptions<Ivanov_Ioana_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Ivanov_Ioana_Proiect.Models.Purchase> Purchase { get; set; }

        public DbSet<Ivanov_Ioana_Proiect.Models.PaymentType> PaymentType { get; set; }

        public DbSet<Ivanov_Ioana_Proiect.Models.Payee> Payee { get; set; }

        public DbSet<Ivanov_Ioana_Proiect.Models.Category> Category { get; set; }
    }
}
