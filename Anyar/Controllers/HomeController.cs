
using System.Threading.Tasks;
using Anyar.DAL;
using Anyar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anyar.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;   
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Employers = await _context.Employers
                .Take(4)
                .ToListAsync()

            };
            return View(homeVM);
        }

 

 
    }
}
