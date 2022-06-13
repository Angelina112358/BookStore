using Microsoft.AspNetCore.Mvc;
using Store.Web.App;
using Store.Web.Models;
using System.Diagnostics;

namespace Store.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService bookService;
        public HomeController(BookService bookService)
        {
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            var books = bookService.GetAllBooks();
            return View("Index", books);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
