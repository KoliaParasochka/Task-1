using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Storages;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public List<Mark> marks = new List<Mark>();
        public Person person = new Person();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guest()
        {
            marks.Add(new Mark("Lexa", "Дизайн отстой!", DateTime.Now));
            marks.Add(new Mark("Kolia", "Дизайн крутой!", DateTime.Now));
            ViewBag.Remarks = marks;
            return View();
        }

        [HttpGet]
        public ActionResult Apply()
        {
            ViewBag.Message = "Введите сюда информацию о себе";

            return View();
        }

        [HttpPost]
        public ActionResult Remark(string author, string remark)
        {
            ViewBag.Author = author;
            ViewBag.Text = remark;
            ViewBag.Date = DateTime.Now.ToString();
            return View();
        }

        [HttpPost]
        public ActionResult CheckInfo(string Name, string LastName, string hasjob, string hascar,
          string haschildren, string male, string female)
        {
            // Writing data into object
            person.Name = Name;
            person.LastName = LastName;
            person.HasJob = hasjob;
            person.HasChildren = haschildren;
            person.HasCar = hascar;
           
            person.Male = male;
            person.Female = female;

            // Getting data from object
            ViewBag.Person = person;
            return View();
        }       
    }
}