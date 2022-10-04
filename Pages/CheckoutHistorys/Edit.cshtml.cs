using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.CheckoutHistorys
{
    public class EditModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public EditModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CheckoutHistory CheckoutHistory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CheckoutHistory == null)
            {
                return NotFound();
            }

            var checkouthistory =  await _context.CheckoutHistory.FirstOrDefaultAsync(m => m.Id == id);
            if (checkouthistory == null)
            {
                return NotFound();
            }
            CheckoutHistory = checkouthistory;
           ViewData["BookID"] = new SelectList(_context.Book, "Id", "Id");
           ViewData["MemberID"] = new SelectList(_context.Set<Member>(), "Id", "Id");
           ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "Id", "Id");
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

            _context.Attach(CheckoutHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckoutHistoryExists(CheckoutHistory.Id))
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

        private bool CheckoutHistoryExists(int id)
        {
          return _context.CheckoutHistory.Any(e => e.Id == id);
        }
    }
}
