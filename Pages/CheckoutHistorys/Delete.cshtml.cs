using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.CheckoutHistorys
{
    public class DeleteModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DeleteModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CheckoutHistory CheckoutHistory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CheckoutHistory == null)
            {
                return NotFound();
            }

            var checkouthistory = await _context.CheckoutHistory.FirstOrDefaultAsync(m => m.Id == id);

            if (checkouthistory == null)
            {
                return NotFound();
            }
            else 
            {
                CheckoutHistory = checkouthistory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CheckoutHistory == null)
            {
                return NotFound();
            }
            var checkouthistory = await _context.CheckoutHistory.FindAsync(id);

            if (checkouthistory != null)
            {
                CheckoutHistory = checkouthistory;
                _context.CheckoutHistory.Remove(CheckoutHistory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
