using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class TeacherCourseController : Controller
    {
        // GET: TeacherCourse
        LearnerContext context = new LearnerContext();

        public ActionResult Index()
        {
            string name = Session["teacherName"].ToString();
            var values = context.Courses.Where(x=>x.Teacher.NameSurname == name).ToList();
            return View(values);
        }

        public ActionResult DeleteCourse(int id)
        {
            var values = context.Courses.Find(id);
            context.Courses.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult AddCourse() 
        {
            List<SelectListItem> category = (from x in context.Categories.Where(x => x.Status == true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.category = category;
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course) 
        {
            string name = Session["teacherName"].ToString(); //loginle giriş yapıyoruz ya giriş yaptıktan sonra bizim cookiye yani sessione bir teacher name ataması yapıyoruz. giriş yapmış olduğumuz süre boyunca session da bir değer tutuyo. yeni kurs eklerken vşew tarafında eğitmeni seçmek istemiyoruz zaten eğitmen olarak giriş yapıyoruz oın agerek yok. o yuzden teacher ıd parametresine atama yapıyoruz. napıyoruz teacher tabosunda eğitmenin id sini seçip bu kısma atoyıoruz. böçylelikle teacher id seçimini controller tarafında yapıyroıuz
            course.TeacherId = context.Teachers.Where(x=>x.NameSurname == name).Select(x=>x.TeacherId).FirstOrDefault();
            context.Courses.Add(course);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCourse(int id)
        {
            List<SelectListItem> category = (from x in context.Categories.Where(x => x.Status == true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CategoryName,
                                                 Value = x.CategoryId.ToString()
                                             }).ToList();
            ViewBag.category = category;
            var values = context.Courses.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var values = context.Courses.Find(course.CourseId);
            string name = Session["teacherName"].ToString();
            values.TeacherId = context.Teachers.Where(x => x.NameSurname == name).Select(x => x.TeacherId).FirstOrDefault();

            values.CategoryId = course.CategoryId;
            values.CourseName = course.CourseName;
            values.Price = course.Price;
            values.Description = course.Description;
            values.ImageUrl = course.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult CourseVideo(Teacher teacher)
        {

            string name = Session["teacherName"].ToString();
            var values = context.CourseVideos.Where(x => x.Teacher.NameSurname == name).ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult AddCourseVideo()
        {
            string name = Session["teacherName"].ToString();
            var courses = context.Courses.Where(x => x.Teacher.NameSurname == name).ToList();


            List<SelectListItem> coursesList = (from x in courses
                                                select new SelectListItem
                                                {
                                                    Text = x.CourseName,
                                                    Value = x.CourseId.ToString()
                                                }).ToList();

            ViewBag.course = coursesList;
            return View();

        }

        [HttpPost]
        public ActionResult AddCourseVideo(CourseVideo courseVideo)
        {
            string name = Session["teacherName"].ToString();
            courseVideo.TeacherId = context.Teachers.Where(x => x.NameSurname == name).Select(x => x.TeacherId).FirstOrDefault();
            context.CourseVideos.Add(courseVideo);
            context.SaveChanges();
            return RedirectToAction("CourseVideo", "TeacherCourse");
        }

        public ActionResult DeleteCourseVideo(int id)
        {
            var values = context.CourseVideos.Find(id);
            context.CourseVideos.Remove(values);
            context.SaveChanges();
            return RedirectToAction("CourseVideo", "TeacherCourse");
        }

        [HttpGet]
        public ActionResult UpdateCourseVideo(int id)
        {
            string name = Session["teacherName"].ToString();
            var video = context.CourseVideos.FirstOrDefault(v => v.CourseVideoId == id && v.Teacher.NameSurname == name);

            if (video == null)
            {
                return HttpNotFound();
            }

            ViewBag.CourseId = new SelectList(context.Courses.Where(x => x.Teacher.NameSurname == name), "CourseId", "CourseName", video.CourseId);

            return View(video);
        }


        [HttpPost]
        public ActionResult UpdateCourseVideo(CourseVideo courseVideo)
        {
            if (!ModelState.IsValid)
            {
                string name = Session["teacherName"].ToString();
                ViewBag.CourseId = new SelectList(context.Courses.Where(x => x.Teacher.NameSurname == name), "CourseId", "CourseName", courseVideo.CourseId);
                return View(courseVideo);
            }

            var existingVideo = context.CourseVideos.Find(courseVideo.CourseVideoId);
            if (existingVideo == null)
            {
                return HttpNotFound();
            }

            existingVideo.CourseId = courseVideo.CourseId;
            existingVideo.VideoNumber = courseVideo.VideoNumber;
            existingVideo.VideoUrl = courseVideo.VideoUrl;
            existingVideo.TeacherId = courseVideo.TeacherId;  

            context.SaveChanges();

            return RedirectToAction("CourseVideo");
        }


        public ActionResult CourseReview(Teacher teacher)
        {
            string name = Session["teacherName"].ToString();

            // Öğretmenin kaydolduğu kursları bul
            var courses = context.Courses.Where(c => c.Teacher.NameSurname == name).ToList();
            var reviews = new List<Review>();
            foreach (var course in courses)
            {
                var courseReviews = context.Reviews.Where(r => r.CourseId == course.CourseId).ToList();
                reviews.AddRange(courseReviews);
            }

            return View(reviews);
        }

        public ActionResult DeleteTeacherCourseReview(int id)
        {
            var value = context.Reviews.Find(id);
            context.Reviews.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CourseReview");
        }

        [HttpGet]
        public ActionResult UpdateTeacherCourseReview(int id)
        {
            var review = context.Reviews.Find(id);

            if (review == null)
            {
                return HttpNotFound();
            }

            return View(review);
        }
        [HttpPost]
        public ActionResult UpdateTeacherCourseReview(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View(review);
            }

            var existingReview = context.Reviews.Find(review.ReviewId);

            if (existingReview == null)
            {
                return HttpNotFound();
            }

            // Sadece ReviewValue ve Comment alanlarını güncelle
            existingReview.ReviewValue = review.ReviewValue;
            existingReview.Comment = review.Comment;

            context.SaveChanges();

            return RedirectToAction("CourseReview");
        }






    }
}