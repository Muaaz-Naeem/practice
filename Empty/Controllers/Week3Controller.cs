using Empty.Models;
using Empty.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empty.Controllers
{
    public class Week3Controller : Controller
    {
        // GET: Week3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomTable()
        {
            var x =  Section.students.ToList();
            return View(x);
        }

        public ActionResult Bootstrap()
        {
             return View();
        }
        public ActionResult EditableTable()
        {
             
            //EmployeeViewModel employees = new EmployeeViewModel { employees = Department.employees.ToList() };

            var employees = Department.employees.ToList();
            return View(employees);
        }

        [HttpPost]
         public ActionResult EditableTable( FormCollection form )
        {
            return RedirectToAction("EditableTable");


            foreach (var key in form.Keys)
            {
                var x = form[key.ToString()];
                Debug.Write(key+"=> ");
                Debug.WriteLine(x);
             }

        }

        public ActionResult EditTable(Employee[] employees)
        {
  
            return View(employees);
        }


        public ActionResult FileUpload()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult FileUpload(FileModel Model)
        {

            Model.Upload(Model);
           // Model.ImageFile.SaveAs(Model.FilePath);

            // var name =Model.ImageFile.FileName;
            //var x=HttpContext.Request;
            return RedirectToAction("ShowFile",Model);
        }

        public ActionResult ShowFile(FileModel model)
        {
            return View(model);
        }
         
    }   
}