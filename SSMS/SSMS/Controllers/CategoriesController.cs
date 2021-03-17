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
        private readonly CategoryBLL _categoryBLL;
        public CategoriesController(CategoryBLL categoryBLL)
        {
            _categoryBLL = categoryBLL;
        }

        public IActionResult Index()
        {
            return View(_categoryBLL.GetAll());
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryBLL.Add(category);
            }
            
            return View(category);
        }
    }
}
