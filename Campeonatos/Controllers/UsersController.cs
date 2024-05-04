using Microsoft.AspNetCore.Mvc;
using Campeonatos.Data;

namespace Campeonatos.Controllers
{
    public class UsersController : Controller
    {
        private CampDbContext _context;

        public UsersController(CampDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
