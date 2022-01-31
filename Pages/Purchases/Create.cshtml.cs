#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ivanov_Ioana_Proiect.Data;
using Ivanov_Ioana_Proiect.Models;

namespace Ivanov_Ioana_Proiect.Pages.Purchases
{
    public class CreateModel : PageModel
    {
        private readonly Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext _context;

        public CreateModel(Ivanov_Ioana_Proiect.Data.Ivanov_Ioana_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PaymentTypeID"] = new SelectList(_context.Set<PaymentType>(), "ID","PaymentTypeName");
            ViewData["PayeeID"] = new SelectList(_context.Set<Payee>(), "ID", "PayeeName");
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");

            return Page();
        }

        [BindProperty]
        public Purchase Purchase { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            /**
           var emptyPurchase = new Purchase();

            if (await TryUpdateModelAsync<Purchase>(
                emptyPurchase,
                "purchase",
                s => s.PurchaseDate, s => s.Price,
                s => s.PaymentTypeID, s => s.PayeeID, s => s.CategoryID,
                s => s.Details))
            {
                    _context.Purchase.Add(emptyPurchase);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");

            }
            return Page();
           **/
            
            if (ModelState.IsValid)
            {
                return Page();
            }

            _context.Purchase.Add(Purchase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
            
        }

    }
}
