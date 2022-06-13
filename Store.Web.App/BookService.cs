using BookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Web.App
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public BookModel GetById(int id)
        {
            var book = bookRepository.GetById(id);
            return Map(book);
        }
        public IReadOnlyCollection<BookModel> GetAllBooks()
        {
            var _books = new List<BookModel>();
            var books = bookRepository.GetAllBooks();
            foreach(var book in books)
            {
                _books.Add(Map(book));
            }
            return _books;
        }
        public IReadOnlyCollection<BookModel> GetAllByQuery(string query)
        {
            var books = Book.IsIsbn(query)
                ? bookRepository.GetAllByIsbn(query)
                : bookRepository.GetAllByTitleOrAuthor(query);
            return books.Select(Map)
                .ToArray();
        }
        private BookModel Map(Book book)
        {
            return new BookModel
            {
                Id = book.Id,
                Isbn = book.Isbn,
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                Price = book.Price,
                //IMG = book.IMG
            };
        }
    }
}
