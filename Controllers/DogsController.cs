using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TinderForDogs.Data;

namespace TinderForDogs.Controllers
{
    public class DogsController : Controller
    {
        private readonly DataDbContext dbContext;

        public DogsController(DataDbContext context)
        {
            dbContext = context;
        }

        // GET: Dogs
        public async Task<IActionResult> Index()
        {
            var dogs = await dbContext.Dogs.Include(d => d.Owner).ToListAsync();
            return View("Views/Dogs/Dogs.cshtml", dogs);
        }

    }
}
