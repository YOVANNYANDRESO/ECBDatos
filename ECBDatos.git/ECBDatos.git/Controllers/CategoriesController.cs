using ECBDatos.git.DAL;
using ECBDatos.git.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECBDatos.git.Controllers
{
    public class CategoriesController:Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
                return  View(await _context.Categories.ToListAsync());
                        
        }



    }
}
