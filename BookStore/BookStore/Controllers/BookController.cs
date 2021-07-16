using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetBookName()
        {
            return "Books Index";
        }

        public string GetBooksById(int id)
        {
            return "Book" + id;
        }

        public string SearchBook(string strBookname, string strAuthorName)
        {
            return $"Boom with Name= {strBookname} and Author = {strAuthorName}";
        }
    }
}
