using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Index1()
        {
            return View();
        }

        public List<BookModel> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public BookModel GetBooksById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBook(string strBookname, string strAuthorName)
        {
            //return $"Boom with Name= {strBookname} and Author = {strAuthorName}";

            return _bookRepository.SearchBook(strBookname, strAuthorName);
        }
    }
}
