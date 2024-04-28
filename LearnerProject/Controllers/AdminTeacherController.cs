using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class AdminTeacherController : Controller
    {
        // GET: AdminTeacher
        LearnerContext context = new LearnerContext();

        public ActionResult Index()
        {
            var values = context.Teachers.ToList();
            return View(values);
        }

        public ActionResult MakeActive(int id)
        {
            var item = context.Teachers.Find(id);

            item.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
          
        }

        public ActionResult MakePassive(int id)
        {
            var item = context.Teachers.Find(id);

            item.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTeacher(int id)
        {
            var value = context.Teachers.Find(id);
            context.Teachers.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacher(Teacher teacher)
        {
            teacher.Status = true;
            context.Teachers.Add(teacher);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public ActionResult UpdateTeacher(int id)
        {
            var value = context.Teachers.Find(id);  
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTeacher(Teacher teacher) 
        {
            var value = context.Teachers.Find(teacher.TeacherId);
            value.NameSurname = teacher.NameSurname;
            value.UserName = teacher.UserName;
            value.Password = teacher.Password;
            value.ImageUrl = teacher.ImageUrl;
            value.Title = teacher.Title;        
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}