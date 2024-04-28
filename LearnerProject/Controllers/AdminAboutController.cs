﻿using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        LearnerContext context = new LearnerContext();

        public ActionResult Index()
        {
            var values = context.Abouts.Where(x => x.Status == true).ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.Abouts.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            about.Status = true;
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);  // Abouts: veri tabanındaki tablonun ismi
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about) //About: snıfımızın ismi, about: parametre
        {
            var value = context.Abouts.Find(about.AboutId);
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageUrl = about.ImageUrl;
            value.Item1 = about.Item1;
            value.Item2 = about.Item2;
            value.Item3 = about.Item3;       
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}