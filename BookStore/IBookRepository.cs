using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string titleOrAuthorPart);
        Book GetById(int id);
        Book[] GetAllByIds(IEnumerable<int> bookIds);
        Book[] GetAllBooks();
    }
}
