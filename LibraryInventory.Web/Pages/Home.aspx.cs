using System;
using LibraryInventory.BLL;
using LibraryInventory.BLL.Repositories;
using LibraryInventory.DAL;

namespace LibraryInventory.Web.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        private readonly BookService _bookService;

        public Home()
        {
            var bookRepository = new BookRepository(new LibraryContext());
            _bookService = new BookService(bookRepository);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBooks();
            }
        }

        private void LoadBooks()
        {
            var books = _bookService.GetAllBooks();
            BooksGridView.DataSource = books;
            BooksGridView.DataBind();
        }
    }
}
