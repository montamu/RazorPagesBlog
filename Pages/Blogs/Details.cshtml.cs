using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBlog.Data;
using RazorPagesBlog.Models;

namespace RazorPagesBlog.Pages_Blogs
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBlog.Data.RazorPagesBlogContext _context;

        public DetailsModel(RazorPagesBlog.Data.RazorPagesBlogContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Blog Blog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blog.FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            else
            {
                Blog = blog;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostLikeAsync(int blogId)
        {
            var blog = await _context.Blog.FindAsync(blogId);

            if (blog == null)
            {
                return NotFound();
            }

            blog.Like += 1;

            _context.Attach(blog).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = blogId });
        }
    }
}
