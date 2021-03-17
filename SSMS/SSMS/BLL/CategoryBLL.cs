using SSMS.DatabaseContext;
using SSMS.Models;
using SSMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSMS.BLL
{
    public class CategoryBLL
    {
        private readonly CategoryReposetory _categoryReposetory;
        public CategoryBLL(CategoryReposetory categoryReposetory)
        {
            _categoryReposetory = categoryReposetory;
        }
        public bool Add(Category category)
        {
            return _categoryReposetory.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryReposetory.GetAll();
        }
    }
}
