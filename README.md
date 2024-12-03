# Library Inventory System

This project is an ASP.NET-based Library Inventory System that provides functionality for managing a library's book inventory. It includes a WebForms application for the user interface and a Web API for programmatic access.

## Features

1. **Database Schema**:
   - **Book**: Contains fields for `Title`, `Author`, `ISBN`, `Publication Year`, and `Quantity`.
   - **Category**: Contains fields for `Category Name` and `Description`.
   - A foreign key relationship exists between `Book` and `Category`.

2. **CRUD Operations**:
   - Supports **Create**, **Read**, **Update**, and **Delete** operations for `Book` and `Category` entities.
   - A stored procedure enables full-text search, pagination, and sorting for books.

3. **ASP.NET WebForms Application**:
   - **Home Page**: Displays a list of all books in a tabular format.
   - **Add Book Page**: Allows adding a new book with its details and associated category.
   - **Edit Book Page**: Allows updating details of an existing book.
   - **Delete Book Page**: Provides confirmation for deleting a book.

4. **ASP.NET Web API**:
   - **GET `api/books`**: Retrieves a list of all books (supports pagination, full-text search, and sorting).
   - **GET `api/books/{id}`**: Retrieves details of a specific book.
   - **POST `api/books`**: Creates a new book.
   - **PUT `api/books/{id}`**: Updates details of a specific book.
   - **DELETE `api/books/{id}`**: Deletes a specific book.

---

## Prerequisites

Before running the project, ensure you have the following installed:
- **Visual Studio 2019 or later** with `.NET Framework 4.7.2` development tools.
- **SQL Server 2016 or later**.
- **Entity Framework 6.x** (already included in the project).

---

## How to Run the Project

### 1. Clone the Repository
```bash
git clone <repository-url>
cd LibraryInventorySystem
