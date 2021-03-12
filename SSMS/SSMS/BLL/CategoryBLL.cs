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
        private readonly CategoryReposetory _repo;
        //SSMSDbContext sSMSDbContext;
        //CategoryReposetory _categoryReposetory = new CategoryReposetory(sSMSDbContext);
        public CategoryBLL(CategoryReposetory repo)
        {
            _repo = repo;
        }
        public bool Add(Category category)
        {
            return _repo.Add(category);
        }

        public List<Category> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
