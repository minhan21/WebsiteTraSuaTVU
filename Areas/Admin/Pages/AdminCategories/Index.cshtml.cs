using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectThoiTrang.Models;

namespace ProjectThoiTrang.Areas.Admin.Pages.AdminCategories
{
    public class IndexModel : PageModel
    {
        private readonly WebFashionContext _context;
        private readonly INotyfService _notify;
        public List<Category> Categories { get; set; } = new List<Category>();
        public IndexModel(WebFashionContext context, INotyfService notify)
        {
            _context = context;
            _notify = notify;
        }
        public async Task OnGetAsync()
        {
            Categories = await _context.Categories.ToListAsync();
        }
    }
}