using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultiSelectDropDown.Data;
using MultiSelectDropDown.Models;

namespace MultiSelectDropDown.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<SelectListItem> listSelectListItem = new List<SelectListItem>();
            foreach (var item in _context.Student)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString(),
                    Selected = item.IsSelected
                };
                listSelectListItem.Add(selectListItem);
            }

            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Student = listSelectListItem;

            return View(studentViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpGet]
        //public IActionResult ChoosenDropDown()
        //{
        //    List<SelectListItem> listSelectListItem = new List<SelectListItem>();
        //    foreach (var item in _context.Student)
        //    {
        //        SelectListItem selectListItem = new SelectListItem()
        //        {
        //            Text = item.Name,
        //            Value = item.Id.ToString(),
        //            Selected = item.IsSelected
        //        };
        //        listSelectListItem.Add(selectListItem);
        //    }

        //    Student student = new Student();
        //    student = listSelectListItem;

        //    return View();
        //}

        //[HttpPost]
        //public IActionResult ChoosenDropDown(List<Student> studentList)
        //{
        //    return RedirectToAction("ChoosenDropDown");
        //}
    }
}
