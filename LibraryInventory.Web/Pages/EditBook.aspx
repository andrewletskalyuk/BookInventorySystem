<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="LibraryInventory.Web.Pages.EditBook" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Edit Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Edit Book</h1>
        <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
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

        <asp:Button ID="UpdateButton" runat="server" Text="Update Book" OnClick="UpdateButton_Click" />
        <br />
        <a href="Home.aspx">Back to Home</a>
    </form>
</body>
</html>
