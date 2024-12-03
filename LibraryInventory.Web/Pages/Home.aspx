<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LibraryInventory.Web.Pages.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Library Books</h1>
        <asp:GridView ID="BooksGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Author" HeaderText="Author" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:BoundField DataField="PublicationYear" HeaderText="Publication Year" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditBook.aspx?id={0}" Text="Edit" HeaderText="Edit" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="DeleteBook.aspx?id={0}" Text="Delete" HeaderText="Delete" />
            </Columns>
        </asp:GridView>
        <br />
        <a href="AddBook.aspx">Add New Book</a>
    </form>
</body>
</html>
