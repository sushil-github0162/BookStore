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
                new BookModel(){Id=6, Title="MVC6", Author = "Sushil Kumar" },
                new BookModel(){Id=7, Title="MVC7", Author = "Sushil Kumar" },
                new BookModel(){Id=8, Title="MVC8", Author = "Sushil Kumar" },
                new BookModel(){Id=9, Title="MVC9", Author = "Sushil Kumar" },
                new BookModel(){Id=10, Title="MVC10", Author = "Sushil Kumar" },
                new BookModel(){Id=11, Title="MVC11", Author = "Sushil Kumar" },
                new BookModel(){Id=12, Title="MVC12", Author = "Sushil Kumar" },
                new BookModel(){Id=13, Title="MVC13", Author = "Sushil Kumar" },
                new BookModel(){Id=14, Title="MVC14", Author = "Sushil Kumar" },
                new BookModel(){Id=15, Title="MVC15", Author = "Sushil Kumar" },
                new BookModel(){Id=16, Title="MVC16", Author = "Sushil Kumar" },
                new BookModel(){Id=17, Title="MVC17", Author = "Sushil Kumar" },
                new BookModel(){Id=18, Title="MVC18", Author = "Sushil Kumar" },
                new BookModel(){Id=19, Title="MVC19", Author = "Sushil Kumar" },
                new BookModel(){Id=20, Title="MVC20", Author = "Sushil Kumar" },
                new BookModel(){Id=21, Title="MVC21", Author = "Sushil Kumar" }
            };
        }
    }
}
