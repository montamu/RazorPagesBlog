using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlog.Data;
using RazorPagesBlog.Models;

namespace RazorPagesBlog.Pages_Comments
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBlog.Data.RazorPagesBlogContext _context;

        public IndexModel(RazorPagesBlog.Data.RazorPagesBlogContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Comment = await _context.Comment
                .Include(c => c.Blog).ToListAsync();
        }
    }
}
