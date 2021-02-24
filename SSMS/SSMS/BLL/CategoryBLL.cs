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
        CategoryReposetory _categoryReposetory = new CategoryReposetory();
        public bool Add(Category category)
        {
            return _categoryReposetory.Add(category);
        }
    }
}
