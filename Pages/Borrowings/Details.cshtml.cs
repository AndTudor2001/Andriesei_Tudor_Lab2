using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Andriesei_Tudor_Lab2.Data;
using Andriesei_Tudor_Lab2.Models;

namespace Andriesei_Tudor_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Andriesei_Tudor_Lab2.Data.Andriesei_Tudor_Lab2Context _context;

        public DetailsModel(Andriesei_Tudor_Lab2.Data.Andriesei_Tudor_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }
      
      
    

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null || _context.Book==null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing
                .Include(b=>b.Book)
                .ThenInclude(b=>b.Author)
                .Include(b=>b.Member)
                .FirstOrDefaultAsync(m => m.ID == id);
            
            if (borrowing == null )
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
                
            }
            return Page();
        }
    }
}
