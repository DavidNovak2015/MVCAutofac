using System.Web.Mvc;
using TestovaciAutofac.Interfaces;
using TestovaciAutofac.Models.Entities;

namespace TestovaciAutofac.Controllers
{
    public class SelectionMaskController : Controller
    {
        // Autofac
        private readonly IselectionMaskViewModel selectionMaskViewModel;

        // Autofac
        public SelectionMaskController(IselectionMaskViewModel iSelectionMaskViewModel)
        {
            selectionMaskViewModel = iSelectionMaskViewModel;
        }

        // vrátí vyhledavaci masku
        public ActionResult GetSelectionMask()
        {
            selectionMaskViewModel.GetSelectionMask();
            return View(selectionMaskViewModel);
        }

        // najde pozadovanou verzi
        [HttpPost]
        public ActionResult FindSelectedVersion (VersionEntity selectedVersion)
        {
            selectionMaskViewModel.GetSelectedVersion(selectedVersion);
            return View(selectionMaskViewModel);
        }
    }
}