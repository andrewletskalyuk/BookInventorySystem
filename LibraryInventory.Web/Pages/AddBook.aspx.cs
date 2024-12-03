using LibraryInventory.BLL.Repositories;
using LibraryInventory.BLL;
using LibraryInventory.DAL.Models;
using LibraryInventory.DAL;
using System;

namespace LibraryInventory.Web.Pages
{
    public partial class AddBook : System.Web.UI.Page
    {
        private readonly BookService _bookService;
        private readonly CategoryService _categoryService;

        public AddBook()
        {
            var categoryRepository = new CategoryRepository(new LibraryContext());
            _categoryService = new CategoryService(categoryRepository);

            var bookRepository = new BookRepository(new LibraryContext());
            _bookService = new BookService(bookRepository);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
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

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var newBook = new Book
            {
                Title = TitleTextBox.Text,
                Author = AuthorTextBox.Text,
                ISBN = ISBNTextBox.Text,
                PublicationYear = int.Parse(PublicationYearTextBox.Text),
                Quantity = int.Parse(QuantityTextBox.Text),
                CategoryId = int.Parse(CategoryDropDown.SelectedValue)
            };

            _bookService.AddBook(newBook);
            Response.Redirect("Home.aspx");
        }
    }
}