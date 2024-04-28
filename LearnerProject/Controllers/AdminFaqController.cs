using LearnerProject.Models.Context;
using LearnerProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnerProject.Controllers
{
    public class AdminFaqController : Controller
    {
        // GET: AdminFaq
        LearnerContext context = new LearnerContext();
        public ActionResult Index()
        {
            var values = context.FAQS.ToList();
            return View(values);
        }

        public ActionResult MakeActive(int id)
        {
            var item = context.FAQS.Find(id);

            item.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MakePassive(int id)
        {
            var item = context.FAQS.Find(id);

            item.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFaq(int id)
        {
            var value = context.FAQS.Find(id);
            context.FAQS.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddFaq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFaq(FAQ faq)
        {
            faq.Status = true;
            context.FAQS.Add(faq);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public ActionResult UpdateFaq(int id)
        {
            var value = context.FAQS.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateFaq(FAQ faq)
        {
            var value = context.FAQS.Find(faq.FAQId);
            value.Question = faq.Question;
            value.Answer = faq.Answer;
            value.ImageUrl = faq.ImageUrl;        
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}