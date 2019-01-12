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
    public class SelectionMaskController : Controller
    {
        private readonly IselectionMaskViewModel selectionMaskViewModel;

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