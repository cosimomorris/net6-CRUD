using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscoBookWeb.Data;
using DiscoBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscoBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

