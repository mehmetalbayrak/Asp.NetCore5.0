using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var blogs = _blogManager.GetListWithCategory();
            return View(blogs);
        }
        public IActionResult BlogDetails(int id)
        {
            var values = _blogManager.GeyById(id);
            return View(values);
        }
    }
}
