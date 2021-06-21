using AutoMapper;
using Empty.AuthData;
using Empty.DTO;
using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;                            
using System.Runtime.Caching;

namespace Empty.Controllers
{
    public class Week4Controller : Controller
    {
         //[OutputCache(Duration =5,VaryByParam ="id",Location =OutputCacheLocation.ServerAndClient)]
     
        [OutputCache(CacheProfile ="medium")]
        public ActionResult UsingCaches(int ? id)
        {
                //Data Cache 
                //var x= new MemoryCache("sss") 
     
            var name = MemoryCache.Default["name"];

            var students = HttpContext.Cache["students"];

            var employee = HttpContext.Cache["employee"];
           var  emp = new Employee { ID = 1, Name = "Muaaz" };

            HttpContext.Cache.Insert("n", emp);

             if (name == null)
            {
                var x = HttpRuntime.Cache;
                var y = HttpContext.Cache;
                var xy = MemoryCache.Default["name"];
                var yz = new Cache();
                

                //caching a single object
                employee = new Employee { ID = 1, Name = "Muaaz" };
                HttpContext.Cache["employee"] = employee;

                
                //caching list of objects
                students = Section.students;
                HttpContext.Cache["students"] = students;
 
                name = "Muaaz";


                 //caching data 
                MemoryCache.Default["name"] = name;

            }
            ViewBag.time = DateTime.Now;
            ViewBag.name = name;
            return View();
        }

        

        public ActionResult UsingCookies()
        {
          
            //Using Cookie Dictionary

            HttpCookie cookie = new HttpCookie("CookieName");
             cookie["Language"] = "Tamil";
             cookie["Country"] = "India";
             Response.Cookies.Add(cookie);


            Response.Cookies["cookie"].Value = "cookie value";
            Response.Cookies["log"].Value = "loged";

  

            ViewBag.cookie = Response.Cookies["cookie"].Value;
           
            
            //session to log in
            Session["log"] = "loged";

            ViewBag.count=Counter.Count++;

        
            return View();





        }



        // GET: Week4
        [CustomAuthFilter]

        public ActionResult Index()
        {
            ViewBag.count = Counter.Count++;

            return View();
         }


        public ActionResult UsingAutoMapper()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UsingAutoMapper(StudentDto studentDto)
        {


            //var config = new MapperConfiguration(cfg => {
            //    cfg.AddProfile<>();
            //    cfg.CreateMap<StudentDto,Student>();
            //});

            //var mapper = config.CreateMapper();
            //// or
            ////IMapper mapper = new Mapper(config);
            //var dest = mapper.Map<StudentDto, Student>(new Source());

            //Mapper.CreateMap<StudentDto, Student>();
            //Mapper.CreateMap<Student, StudentDto>();
            
            //var student = Mapper.Map<StudentDto, Student>(studentDto);

            //var stdDto = Mapper.Map<Student, StudentDto>(student);



            //Section.students.Add(student);

            var list = Section.students;

            return View();
        }
    }
}