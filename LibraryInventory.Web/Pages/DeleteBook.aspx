<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="LibraryInventory.Web.Pages.DeleteBook" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Delete Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Delete Book</h1>
        <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="ConfirmationMessage" runat="server" Text="Are you sure you want to delete this book?"></asp:Label>
        <br />
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
    </form>
</body>
</html>
