using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1;
using ConsoleApp1.Models;

namespace WebApplication7.Products
{
    public class IndexModel : PageModel
    {
        private readonly ConsoleApp1.ContosoPetContext _context;

        public IndexModel(ConsoleApp1.ContosoPetContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
