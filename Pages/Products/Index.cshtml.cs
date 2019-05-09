using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Project_Homekit_4.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Final_Project_Homekit_4.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Final_Project_Homekit_4.Models.HomekitDbContext _context;
        private readonly ILogger _logger;

        public IndexModel(Final_Project_Homekit_4.Models.HomekitDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product> Product { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Categories { get; set; }
        public SelectList SortList {get; set;}
        [BindProperty(SupportsGet = true)]
        public string ProductCategory { get; set; }

        // PageSize: How many records to display per page.
        // Default: 10
        public int PageSize {get; set;} = 10;

        // PageNum: Current Page Number we are on. Default is 1
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;

        public int TotalCount {get; set;} // Total number of records
        public int TotalPages {get; set;} // Total number of pages
        
        // String to keep track of our current sort order. Needed for 
        // paging to remember current sort
        public string CurrentSort {get; set;} 
        
        // Next Sort for Title and Date sort. This alternates between asc/desc
        public string ProductNameSort {get; set;} = "PN_asc";
        public string PriceSort {get; set;} = "Price_asc";

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;

            // Sorting Technique 2. Create a SelectList of sort options.
            // Set the values equal to our expected sort strings
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem {Text = "Product Name A to Z", Value = "PN_asc"},
                new SelectListItem("Product Name Z to A", "PN_desc"),
                new SelectListItem("Price Low to High", "Price_asc"),
                new SelectListItem("Price High to Low", "Price_desc")
            };
            // Default value will be CurrentSort
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);
            
            // Use LINQ to get list of categories.
            IQueryable<string> categoryQuery = from m in _context.Product
                                            orderby m.Category
                                            select m.Category;
            
            // Use .Include() to bring in the brands
            var query = _context.Product.Include(m => m.Brand).Select(m => m);
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(s => s.ProductName.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(ProductCategory))
            {
                query = query.Where(x => x.Category == ProductCategory);
            }

            // Calculate total number of records and how many pages that takes
            TotalCount = query.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());

            // Do the sorting. This is the brains of sorting
            // Switch on sort Order and perform proper LINQ query
            switch (sortOrder) 
            {
                case "PN_desc":
                    _logger.LogInformation("Sorting by Product Name Z to A");
                    query = query.OrderByDescending(m => m.ProductName);
                    ProductNameSort = "PN_asc";
                    break;
                case "PN_asc":
                    _logger.LogInformation("Sorting by Product Name A to Z");
                    query = query.OrderBy(m => m.ProductName);
                    ProductNameSort = "PN_desc";
                    break;
                case "date_desc":
                    _logger.LogInformation("Sorting by Price High to Low");
                    query = query.OrderByDescending(m => m.ProductPrice);
                    PriceSort = "Price_asc";
                    break;
                case "date_asc":
                    _logger.LogInformation("Sorting by Price Low to High");
                    query = query.OrderBy(m => m.ProductPrice);
                    PriceSort = "Price_desc";
                    break;
                default:
                    _logger.LogInformation("No Sorting");
                    break;
            }

            Product = query.ToList();

            Product = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

        //public async Task OnGetAsync()
        //{
            //Product = await _context.Product
                //.Include(p => p.Brand).ToListAsync();
        }
    }
}
