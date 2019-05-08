using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project_Homekit_4.Models;

namespace Final_Project_Homekit_4.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Final_Project_Homekit_4.Models.HomekitDbContext _context;

        public CreateModel(Final_Project_Homekit_4.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandID"] = new SelectList(_context.Brand, "BrandID", "BrandName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}