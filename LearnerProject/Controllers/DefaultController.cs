using LearnerProject.Models;
using LearnerProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        LearnerContext context = new LearnerContext();
        public ActionResult Index()
        {
            ViewBag.v1 = context.Courses.Count();
            ViewBag.v2 = context.Students.Count();
            ViewBag.v3 = context.Teachers.Count();
            ViewBag.v4 = context.Categories.Count();
           
            return View();
        }

        public PartialViewResult DefaultCoursePartial()
        {
            ViewBag.v1 = context.Courses.Count();
     
            var values = context.Courses.Include(x=>x.Reviews).OrderByDescending(x=>x.CourseId).Take(6).ToList();
            return PartialView(values);
        }

        public ActionResult CourseDetail(int id)
        {
            var values = context.Courses.Find(id);
            var reviewList = context.Reviews.Where(x=>x.CourseId == id).ToList();
            ViewBag.review = reviewList;
            return View(values);
        }

        public PartialViewResult DefaultTestimonialPartial()
        {
            var values = context.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultCategoryPartial()
        {
            ViewBag.v1 = context.Courses.Where(x => x.Category.CategoryName == "Kodlama").Count();  // kategori adı kodlama olan kursların sayısı


            var values = context.Categories.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultClassroomPartial()
        {
            var values = context.Classrooms.Where(x => x.Status == true).OrderByDescending(x => x.ClassroomId).Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultAboutPartial()
        {
           
            var values = context.Abouts.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultTeacherPartial()
        {
            var values = context.Teachers.Where(x => x.Status == true).OrderByDescending(x => x.TeacherId).Take(6).ToList();
            return PartialView(values);
        }

        public PartialViewResult DefaultFAQPartial()
        {
            //var values = context.FAQS.ToList();
            var values = context.FAQS.Where(x => x.Status == true).OrderByDescending(x => x.FAQId).Take(8).ToList();

            return PartialView(values);
        }




    }
}