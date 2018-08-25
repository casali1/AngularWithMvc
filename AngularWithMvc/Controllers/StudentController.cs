using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularWithMvc.Models;
using AngularWithMvc.Service;

namespace AngularWithMvc.Controllers
{
    public class StudentController : Controller
    {
        ListOfData list = new ListOfData();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddStudent(Student stu)
        {
            if (stu != null)
            {
                list.AddStudent(stu);
                return Json(stu, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Some Error Occured");
            }
        }

        [HttpPost]
        public string UpdateStudent(Student stu)
        {
            if (stu != null)
            {
                list.UpdateStudent(stu);
                return "Student Updated";
            }
            else
            {
                return "Oops! something went wrong.";
            }
        }

        public JsonResult GetStudentList()
        {
            var studentList = list.GetStudents();
            return Json(studentList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string DeleteStudent(int Id)
        {
            if (Id != 0)
            {
                list.DeleteFromList(Id);
                return "Student has been deleted succhessfully.";
            }
            else
            {
                return " Oops! Error occered.";
            }
        }
    }
}
