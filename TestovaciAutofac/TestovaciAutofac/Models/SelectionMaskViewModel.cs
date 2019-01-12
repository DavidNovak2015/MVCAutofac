using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestovaciAutofac.Interfaces;
using TestovaciAutofac.Models.Entities;
using TestovaciAutofacDB.DbEntities;
using TestovaciAutofacDB.Interfaces;

namespace TestovaciAutofac.Models
{
    public class SelectionMaskViewModel:IselectionMaskViewModel
    {
        //Autofac
        private readonly IversionsRepository versionsRepository;

        //nacteni vsech verzi do DropDownListu
        public List<SelectListItem> AllVersions { get; set;}

        //ulozeni vybrane verze
        public VersionEntity SelectedVersion { get; set; }


        //Autofac
        public SelectionMaskViewModel(IversionsRepository iVersionsRepository)
        {
            versionsRepository = iVersionsRepository;
        }

        //nastavi vyhledavaci masku
        public void GetSelectionMask()
        {
            List<VersionEntityDB> allVersionsFromDB= versionsRepository.GetAllVersions();

            if (AllVersions == null)
                AllVersions = new List<SelectListItem>();

            if (AllVersions.Count == 0)
            {
                foreach (VersionEntityDB version in allVersionsFromDB)
                    {
                        AllVersions.Add(new SelectListItem { Text = version.Name, Value = version.Name });
                    }
            }
        }

        //vrati pozadovanou verzi
        public void GetSelectedVersion (VersionEntity selectedVersion)
        {
            VersionEntityDB selectedVersionDB = new VersionEntityDB(selectedVersion.Name);
            VersionEntityDB foundVersionDB = versionsRepository.GetSelectedVersion(selectedVersionDB);

            SelectedVersion = new VersionEntity(foundVersionDB.Name);
        }
    }
}