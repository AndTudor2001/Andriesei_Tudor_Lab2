using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Andriesei_Tudor_Lab2.Data;
using Andriesei_Tudor_Lab2.Models;

namespace Andriesei_Tudor_Lab2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Andriesei_Tudor_Lab2.Data.Andriesei_Tudor_Lab2Context _context;

        public IndexModel(Andriesei_Tudor_Lab2.Data.Andriesei_Tudor_Lab2Context context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
