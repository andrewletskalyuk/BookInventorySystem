﻿using LibraryInventory.DAL.Models;
using System.Collections.Generic;

namespace LibraryInventory.Core.Contracts
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        Book GetBookById(int id);
        
        void AddBook(Book book);
        
        void UpdateBook(Book book);
        
        void DeleteBook(int id);
    }
}
