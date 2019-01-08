using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestovaciAutofac.Interfaces;
using TestovaciAutofac.Models;
using TestovaciAutofac.Models.Entities;

namespace TestovaciAutofac.Controllers
{
    public class VersionsController : Controller
    {
        //Autofac
        private readonly IversionsViewModel versionsViewModel;

        //Autofac
        public VersionsController(IversionsViewModel iVersionsViewModel)
        {
            versionsViewModel = iVersionsViewModel;
        }

        public ActionResult GetTodayVersions()
        {
            versionsViewModel.GetTodaysVersions();
            return View(versionsViewModel);
        }

        public ActionResult AddVersion()
        {
            versionsViewModel.AddForm();
            return View(versionsViewModel);
        }

        [HttpPost]
        public ActionResult AddVersion(VersionsViewModel versionToDB)
        {
            TempData["result"]=versionsViewModel.AddVersion(versionToDB.VersionEntity);
            return RedirectToAction("GetTodayVersions");
        }
    }
}