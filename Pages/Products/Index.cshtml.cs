using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_Homekit_4.Models;

namespace Final_Project_Homekit_4.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project_Homekit_4.Models.HomekitDbContext _context;

        public IndexModel(Final_Project_Homekit_4.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Brand).ToListAsync();
        }
    }
}
