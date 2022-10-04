using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;

namespace Project.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public DetailsModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

      public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Staff == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FirstOrDefaultAsync(m => m.Id == id);
            if (staff == null)
            {
                return NotFound();
            }
            else 
            {
                Staff = staff;
            }
            return Page();
        }
    }
}
