using Empty.AuthData;
using Empty.Models;
using Empty.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.AuthData;

namespace Empty.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home



        public ActionResult Raw()
        {


            TestModel tm = new TestModel { Money = 90 };

            ViewBag.rawHTML = "<b>this is a bold text from raw HTML</b>";

            return View(tm);
        }
        public ViewResult CustomHelperMethods()
        {

            return View();

        }

        public ViewResult ContextItems()
        {

            return View();

        }

        public ViewResult showSection()
        {

            return View();

        }
        public ViewResult Index()
        {


            //ViewBag.list = stringList;
            return View(Section.students.ToList());
        }



        public PartialViewResult EmptList()
        {
            return PartialView("empt");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var student = Section.students.Find(x => x.ID == id);


            Section.students.Remove(student);
            return RedirectToAction("Index");
        }


        public ViewResult Create()
        {
            //StudentViewModel student = new StudentViewModel { sections = School.sections };
            ViewBag.Sections = new SelectList(School.sections, "ID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {

            //try
            //{
            //    if (student.Resume.ContentLength > 0)
            //    {
            //        string _FileName = Path.GetFileName(student.Resume.FileName);
            //        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
            //        student.Resume.SaveAs(_path);
            //    }
            //    ViewBag.Message = "File Uploaded Successfully!!";
            //    return View();
            //}
            //catch
            //{
            //    ViewBag.Message = "File upload failed!!";
            //    return View();
            //}


            //if (student.Autobiograpy == null)
            //    ModelState.AddModelError(nameof(student.Autobiograpy), "Autobiography must contain a few lines");
            if (ModelState.IsValid)
            {
                TempData["created"] = true;
                return RedirectToAction("StudentProfile", student);
            }
            //StudentViewModel viewModel = new StudentViewModel {Student= student };
            ViewBag.Sections = new SelectList(School.sections, "ID", "Name");

            return View();
            //student.ID = Section.students.Last().ID + 1;
            //Student newStudent = new Student { ID = student.ID, Name = student.Name };
            //Section.students.Add(newStudent);
            //return RedirectToAction("Index");

        }


        [HttpPost]
        public JsonResult IsAlreadyExist(string Name)
        {

            return Json(!Section.students.Any(student => student.Name == Name));

        }


        [HttpPost]
        public JsonResult IsAlreadySigned(string UserEmailId)
        {

            return Json(IsUserAvailable(UserEmailId));

        }
        public bool IsUserAvailable(string EmailId)
        {
            // Assume these details coming from database  
            List<RegisterModel> RegisterUsers = new List<RegisterModel>()
        {

            new RegisterModel {UserEmailId="admin@gmail.com" ,PassWord="compilemode",Designation="SE"},
            new RegisterModel {UserEmailId="Sudhir@abc.com" ,PassWord="abc123",Designation="Software Dev"}

        };
            var RegEmailId = (from u in RegisterUsers
                              where u.UserEmailId.ToUpper() == EmailId.ToUpper()
                              select new { EmailId }).FirstOrDefault();

            bool status;
            if (RegEmailId != null)
            {
                //Already registered  
                status = false;
            }
            else
            {
                //Available to use  
                status = true;
            }


            return status;
        }

        public ActionResult RegisterModel()
        {
            return View();
        }

        //[HttpPost]
        // public JsonResult IsUserNameAvailable(string Name)
        //{
        //    return Json(!Section.students.Any(n => n.Name == Name));
        //}
        public ActionResult StudentProfile(Student student) {

            var sectionName = School.sections.SingleOrDefault(section => section.ID == student.SectionID).Name;
            student.section = new Section();
            student.section.Name = sectionName;

            return View(student);
        }


        public ViewResult Update(int id)
        {
            var student = Section.students.Find(x => x.ID == id);

            return View(student);
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            var studentStored = Section.students.Find(x => x.ID == student.ID);
            studentStored.Name = student.Name;
            return RedirectToAction("Index");

        }

  
   }


}
 