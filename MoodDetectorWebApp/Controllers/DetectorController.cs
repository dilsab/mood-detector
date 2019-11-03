﻿using ControllerProject.Service;
using Model;
using Model.Entity;
using MoodDetectorWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Web.Mvc;

namespace MoodDetectorWebApp.Controllers
{
    public class DetectorController : Controller
    {
        private IMoodService _moodService;

        public DetectorController(IMoodService moodService)
        {
            _moodService = moodService;
        }

        // GET: Detector
        [HttpGet]
        public ActionResult Detect()
        {
            return View(new DetectViewModel());
        }

        // POST: Detector
        [HttpPost]
        public ActionResult Detect(DetectViewModel model)
        {
            SessionInfo sessionInfo = new SessionInfo()
            {
                User = new User() { Id = 3 },
                Class = model.Class,
                Comments = model.Comments,
                Subject = model.Subject,
                DateTime = DateTime.Now,
                MessageSeen = 0,
            };

            int detectionId =_moodService.AddSession(sessionInfo);
            DetectionStartViewModel detectionStartViewModel = new DetectionStartViewModel()
            {
                DetectionId = detectionId,
            };

            return View("~/Views/Detector/Start.cshtml", detectionStartViewModel);
        }

        // POST: Detector/PostMoods/
        public void PostMoods(int detectionId, string moods)
        {
            _moodService.AddMood(detectionId, JsonConvert.DeserializeObject<MoodCollection>(moods));
        }
    }
}