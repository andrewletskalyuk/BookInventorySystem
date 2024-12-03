<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="LibraryInventory.Web.Pages.AddBook" %>
<!DOCTYPE html>
<html>
<head>
    <title>Add New Book</title>
</head>
<body>
    <h1>Add New Book</h1>
    <form runat="server">
        <label>Title:</label>
        <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox><br />

        <label>Author:</label>
        <asp:TextBox ID="AuthorTextBox" runat="server"></asp:TextBox><br />

        <label>ISBN:</label>
        <asp:TextBox ID="ISBNTextBox" runat="server"></asp:TextBox><br />

        <label>Publication Year:</label>
        <asp:TextBox ID="PublicationYearTextBox" runat="server"></asp:TextBox><br />

        <label>Quantity:</label>
        <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox><br />

        <label>Category:</label>
        <asp:DropDownList ID="CategoryDropDown" runat="server"></asp:DropDownList><br />

        <asp:Button ID="SubmitButton" runat="server" Text="Add Book" OnClick="SubmitButton_Click" />
    </form>
</body>
</html>
