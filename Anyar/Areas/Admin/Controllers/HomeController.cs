using Anyar.DAL;
using Anyar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anyar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public HomeController(AppDbContext context,IWebHostEnvironment env)
        {
            _context=context;
            _env=env;    

        }
        public async Task<IActionResult> Index()
        {
           List< GetEmployerVM> employerVM = await _context.Employers.Select(e => new GetEmployerVM
            {
                Name = e.Name,
                Surname = e.Surname,
                Description = e.Description,
                Image = e.Image,
                Prefossion = e.Prefossion,
            }).ToListAsync();
            
            return View(employerVM);
        }
    }
}
