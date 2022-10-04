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
    public class IndexModel : PageModel
    {
        private readonly Project.Data.ProjectContext _context;

        public IndexModel(Project.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<CheckoutHistory> CheckoutHistory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CheckoutHistory != null)
            {
                CheckoutHistory = await _context.CheckoutHistory
                .Include(c => c.Book)
                .Include(c => c.Member)
                .Include(c => c.Staff).ToListAsync();
            }
        }
    }
}
