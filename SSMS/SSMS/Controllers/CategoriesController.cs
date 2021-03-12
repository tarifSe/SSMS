using Microsoft.AspNetCore.Mvc;
using SSMS.BLL;
using SSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSMS.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryBLL _cbll;
        public CategoriesController(CategoryBLL cbll)
        {
            _cbll = cbll;
        }

        
        public IActionResult Add()
        {
            return View(_cbll.GetAll());
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _cbll.Add(category);
            return View(category);
        }

        //public string Add(Category category)
        //{
        //    _categoryBLL.Add(category);
        //    return "Added";
        //}
    }
}
