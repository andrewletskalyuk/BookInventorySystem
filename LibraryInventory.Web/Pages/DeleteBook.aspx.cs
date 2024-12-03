using System;
using LibraryInventory.BLL;
using LibraryInventory.BLL.Repositories;
using LibraryInventory.DAL;

namespace LibraryInventory.Web.Pages
{
    public partial class DeleteBook : System.Web.UI.Page
    {
        private readonly BookService _bookService;
        private int _bookId;

        public DeleteBook()
        {
            var bookRepository = new BookRepository(new LibraryContext());
            _bookService = new BookService(bookRepository);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!int.TryParse(Request.QueryString["id"], out _bookId))
            {
                ErrorMessage.Text = "Invalid book ID.";
                ErrorMessage.Visible = true;
                DeleteButton.Enabled = false;
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_bookId > 0)
            {
                _bookService.DeleteBook(_bookId);
                Response.Redirect("Home.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
