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
        //private readonly SSMSDbContext _context;
        //public CategoryReposetory(SSMSDbContext sSMSDbContext)
        //{
        //    _context = sSMSDbContext;
        //}

        SSMSDbContext _context = new SSMSDbContext();
        public bool Add(Category category)
        {
            int isExecuted = 0;
            //int isEx = 0;

            _context.Categories.Add(category);
            isExecuted = _context.SaveChanges();
            //isEx = Convert.ToInt32(_context.SaveChangesAsync());

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
    }
}
