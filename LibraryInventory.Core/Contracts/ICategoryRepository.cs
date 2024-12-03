using LibraryInventory.DAL.Models;
using System.Collections.Generic;

namespace LibraryInventory.Core.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        
        Category GetCategoryById(int id);
        
        void AddCategory(Category category);
        
        void UpdateCategory(Category category);
        
        void DeleteCategory(int id);
    }
}
