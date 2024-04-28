﻿using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class AdminCourseController : Controller
    {
        // GET: AdminCourse
        LearnerContext context = new LearnerContext();
        public ActionResult Index()
        {
            string adminName = Session["adminName"].ToString();
            var admin = context.Admins.Where(x => x.NameSurname == adminName).Select(x => x.AdminId).FirstOrDefault();
            var values = context.Courses.ToList();
            return View(values);
        }

        public ActionResult DeleteCourse(int id) 
        {
            var value = context.Courses.Find(id);
            context.Courses.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult AddCourse()
        {
           List<SelectListItem> category = (from x in context.Categories.Where(x=>x.Status ==true).ToList() select new SelectListItem
           {
               Text = x.CategoryName,
               Value = x.CategoryId.ToString()
           }).ToList();

            List<SelectListItem> teacher = (from x in context.Teachers.Where(x => x.Status == true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.NameSurname,
                                                 Value = x.TeacherId.ToString()
                                             }).ToList();
            ViewBag.category = category;
            ViewBag.teacher = teacher;
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
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
            List<SelectListItem> teacher = (from x in context.Teachers.Where(x => x.Status == true).ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.NameSurname,
                                                Value = x.TeacherId.ToString()
                                            }).ToList();
            ViewBag.teacher = teacher;
            ViewBag.category = category;

            var value = context.Courses.Find(id);
            return View(value);
        }


        [HttpPost]
        public ActionResult UpdateCourse(Course course)
        {
            var value = context.Courses.Find(course.CourseId);
            value.CourseName = course.CourseName;
            value.CategoryId = course.CategoryId;
            value.ImageUrl = course.ImageUrl;
            value.Price = course.Price;
            value.Description = course.Description;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}