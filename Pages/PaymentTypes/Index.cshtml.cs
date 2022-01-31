#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Proiect.Data;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Pages.PaymentTypes
{
    public class IndexModel : PageModel
    {
        private readonly Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext _context;

        public IndexModel(Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext context)
        {
            _context = context;
        }

        public IList<PaymentType> PaymentType { get;set; }

        public async Task OnGetAsync()
        {
            PaymentType = await _context.PaymentType.ToListAsync();
        }
    }
}
