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
        CategoryBLL _categoryBLL = new CategoryBLL();

        //[HttpPost]
        //public IActionResult Add()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Add(Category category)
        //{
        //    _categoryBLL.Add(category);
        //    return View();
        //}

        public string Add(Category category)
        {
            _categoryBLL.Add(category);
            return "Added";
        }
    }
}
