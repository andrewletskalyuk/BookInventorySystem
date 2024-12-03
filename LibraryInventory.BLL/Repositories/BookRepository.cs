using LibraryInventory.Core.Contracts;
using LibraryInventory.DAL;
using LibraryInventory.DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LibraryInventory.BLL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.Include(b => b.Category).ToArray();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Include(b => b.Category).FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
