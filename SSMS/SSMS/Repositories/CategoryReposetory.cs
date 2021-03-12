using SSMS.DatabaseContext;
using SSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSMS.Repositories
{
    public class CategoryReposetory
    {
        private readonly SSMSDbContext _context;
        public CategoryReposetory(SSMSDbContext sSMSDbContext)
        {
            _context = sSMSDbContext;
        }

        public bool Add(Category category)
        {
            int isExecuted = 0;

            _context.Add(category);
            isExecuted = _context.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
