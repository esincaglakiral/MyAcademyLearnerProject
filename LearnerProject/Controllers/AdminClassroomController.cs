using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class AdminClassroomController : Controller
    {
        // GET: AdminClassroom
        LearnerContext context = new LearnerContext();
        public ActionResult Index()
        {
            var values = context.Classrooms.ToList();
            return View(values);
        }

        public ActionResult MakeActive(int id)
        {
            var item = context.Classrooms.Find(id);

            item.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MakePassive(int id)
        {
            var item = context.Classrooms.Find(id);

            item.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteClassroom(int id)
        {
            var value = context.Classrooms.Find(id);
            context.Classrooms.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddClassroom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClassroom(Classroom classroom)
        {
            classroom.Status = true;
            context.Classrooms.Add(classroom);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult UpdateClassroom(int id)
        {
            var value = context.Classrooms.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateClassroom(Classroom classroom)
        {
            var value = context.Classrooms.Find(classroom.ClassroomId);
            value.Name = classroom.Name;
            value.Icon = classroom.Icon;
            value.Description = classroom.Description;
          
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}