using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project.Data;
using Project.Models;

namespace Project.Pages.Books
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
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "FullName");
            // ViewData["MemberID"] = new SelectList(_context.Set<Member>(), "Id", "FullName");
            ViewData["MemberID"] = new SelectList(_context.Set<Member>(), "Id", "FullName").
                Prepend(new SelectListItem("-- SelectList Author--", ""));
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
