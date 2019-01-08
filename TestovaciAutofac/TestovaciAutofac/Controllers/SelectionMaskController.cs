using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestovaciAutofac.Interfaces;

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
    }
}