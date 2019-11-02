﻿using ControllerProject.Service;
using System.Collections.Generic;
using System.Web.Mvc;
using Model;

namespace MoodDetectorWebApp.Controllers
{
    public class MoodController : Controller
    {
        MoodService moodService = new MoodService(new Model.MoodDetectorDBEntities());

        // GET: Mood/Mood/
        public ActionResult MoodIndex()
        {
            return View();
        }

        // GET: Mood/MoodList/
        public ActionResult GetMoodList(int id)
        {
            List<Mood> moods = moodService.GetMoodsByDate(new User() { Id = id });
            
            return View("MoodList", moods);
        }

        // GET: Mood/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mood/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mood/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mood/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mood/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mood/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mood/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}