using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Data;
using Project.Models;

namespace Project.Pages.CheckoutHistorys
{
    public class CreateModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public CreateModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookID"] = new SelectList(_context.Book, "Id", "Id");
        ViewData["MemberID"] = new SelectList(_context.Set<Member>(), "Id", "Id");
        ViewData["StaffID"] = new SelectList(_context.Set<Staff>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public CheckoutHistory CheckoutHistory { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CheckoutHistory.Add(CheckoutHistory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
