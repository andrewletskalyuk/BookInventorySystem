using System;
using LibraryInventory.BLL;
using LibraryInventory.BLL.Repositories;
using LibraryInventory.DAL;
using LibraryInventory.DAL.Models;

namespace LibraryInventory.Web.Pages
{
    public partial class EditBook : System.Web.UI.Page
    {
        private readonly BookService _bookService;
        private readonly CategoryService _categoryService;
        private int _bookId;

        public EditBook()
        {
            var bookRepository = new BookRepository(new LibraryContext());
            _bookService = new BookService(bookRepository);

            var categoryRepository = new CategoryRepository(new LibraryContext());
            _categoryService = new CategoryService(categoryRepository);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["id"], out _bookId))
                {
                    LoadBookDetails(_bookId);
                    LoadCategories();
                }
                else
                {
                    ErrorMessage.Text = "Invalid book ID.";
                    ErrorMessage.Visible = true;
                }
            }
        }

        private void LoadBookDetails(int bookId)
        {
            var book = _bookService.GetBookById(bookId);
            if (book != null)
            {
                TitleTextBox.Text = book.Title;
                AuthorTextBox.Text = book.Author;
                ISBNTextBox.Text = book.ISBN;
                PublicationYearTextBox.Text = book.PublicationYear.ToString();
                QuantityTextBox.Text = book.Quantity.ToString();
                CategoryDropDown.SelectedValue = book.CategoryId.ToString();
            }
            else
            {
                ErrorMessage.Text = "Book not found.";
                ErrorMessage.Visible = true;
            }
        }

        private void LoadCategories()
        {
            var categories = _categoryService.GetAllCategories();
            CategoryDropDown.DataSource = categories;
            CategoryDropDown.DataTextField = "Name";
            CategoryDropDown.DataValueField = "Id";
            CategoryDropDown.DataBind();
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["id"], out _bookId))
            {
                var book = new Book
                {
                    Id = _bookId,
                    Title = TitleTextBox.Text,
                    Author = AuthorTextBox.Text,
                    ISBN = ISBNTextBox.Text,
                    PublicationYear = int.Parse(PublicationYearTextBox.Text),
                    Quantity = int.Parse(QuantityTextBox.Text),
                    CategoryId = int.Parse(CategoryDropDown.SelectedValue)
                };

                _bookService.UpdateBook(book);
                Response.Redirect("Home.aspx");
            }
        }
    }
}
