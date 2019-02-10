using System.Web.Mvc;
using TestovaciAutofac.Interfaces;
using TestovaciAutofac.Models;

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

        // vrati dnesni verze
        public ActionResult GetTodayVersions()
        {
            versionsViewModel.GetTodaysVersions();
            return View(versionsViewModel);
        }

        // zobrazeni prazdneho formulare
        public ActionResult AddVersion()
        {
            versionsViewModel.AddForm();
            return View(versionsViewModel);
        }

        // ulozeni nove verze 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVersion(VersionsViewModel versionToDB)
        {
            TempData["result"]=versionsViewModel.AddVersion(versionToDB.Version);
            return RedirectToAction("GetTodayVersions");
        }
    }
}