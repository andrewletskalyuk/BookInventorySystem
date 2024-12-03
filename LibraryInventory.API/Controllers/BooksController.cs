using LibraryInventory.BLL.Repositories;
using LibraryInventory.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using LibraryInventory.DAL;
using LibraryInventory.DAL.Models;
using System.Net;

namespace LibraryInventory.API.Controllers
{
    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private readonly BookService _bookService;

        public BooksController()
        {
            var bookRepository = new BookRepository(new LibraryContext());
            _bookService = new BookService(bookRepository);
        }

        //[HttpGet]
        //[Route("")]
        //public IHttpActionResult GetBooks(string search = null, string sort = "Title", int page = 1, int pageSize = 10)
        //{
        //    var books = _bookService.GetAllBooks();

        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        books = books.Where(b =>
        //            b.Title.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
        //            b.Author.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 ||
        //            b.ISBN.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
        //    }

        //    switch (sort)
        //    {
        //        case "Title":
        //            books = books.OrderBy(b => b.Title);
        //            break;
        //        case "Author":
        //            books = books.OrderBy(b => b.Author);
        //            break;
        //        case "PublicationYear":
        //            books = books.OrderBy(b => b.PublicationYear);
        //            break;
        //        case "Quantity":
        //            books = books.OrderBy(b => b.Quantity);
        //            break;
        //        default:
        //            books = books.OrderBy(b => b.Title);
        //            break;
        //    }

        //    var paginatedBooks = books.Skip((page - 1) * pageSize).Take(pageSize);

        //    return Ok(paginatedBooks);
        //}
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetBook(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult CreateBook(Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _bookService.AddBook(book);
            return StatusCode(HttpStatusCode.Created);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult UpdateBook(int id, Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingBook = _bookService.GetBookById(id);
            if (existingBook == null)
                return NotFound();

            book.Id = id;
            _bookService.UpdateBook(book);

            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult DeleteBook(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
                return NotFound();

            _bookService.DeleteBook(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}