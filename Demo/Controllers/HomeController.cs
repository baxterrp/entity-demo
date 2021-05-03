using Demo.Context;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        DemoDbContext _context;

        public HomeController(DemoDbContext demoDbContext)
        {
            _context = demoDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> AddTask(ToDoTask toDoTask)
        {
            _context.Tasks.Add(toDoTask);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> RegisterUser(LoginModel loginModel)
        {
            // add our user to the context
            _context.Users.Add(loginModel);

            // updates the db with the new info
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
