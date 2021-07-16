using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string bookName, string author)
        {
            return DataSource().Where(x => x.Title.Contains(bookName) && x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author = "Sushil Kumar" },
                new BookModel(){Id=2, Title="MVC2", Author = "Sushil Kumar" },
                new BookModel(){Id=3, Title="MVC3", Author = "Sushil Kumar" },
                new BookModel(){Id=4, Title="MVC4", Author = "Sushil Kumar" },
                new BookModel(){Id=5, Title="MVC5", Author = "Sushil Kumar" },
            };
        }
    }
}
