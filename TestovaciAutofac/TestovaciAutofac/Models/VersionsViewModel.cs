using System.Collections.Generic;
using System.Linq;
using TestovaciAutofac.Models.Entities;
using TestovaciAutofacDB.Interfaces;
using TestovaciAutofacDB.DbEntities;
using TestovaciAutofac.Interfaces;

namespace TestovaciAutofac.Models
{
    public class VersionsViewModel:IversionsViewModel
    {
        // zobrazeni dnesnich verzi
        public List<VersionEntity> TodaysVersions { get; private set; }

        // pristup k objektu verze
        public VersionEntity Version { get; set; }

        // Autofac
        private readonly IversionsRepository versionsRepository;

        // Autofac
        public VersionsViewModel(IversionsRepository iVersionsRepository)
        {
            versionsRepository = iVersionsRepository;
        }

        public VersionsViewModel()
        { }

        // vrati dnesni verze
        public void GetTodaysVersions()
        {
            List<VersionEntityDB> todaysVersionsFromDB = versionsRepository.GetTodaysVersions();

            TodaysVersions = todaysVersionsFromDB.Select(x => new VersionEntity(x.Name
                                                                               )
                                                        ).ToList();
        }

        // zobrazeni prazdneho formulare
        public void AddForm()
        {
            Version = new VersionEntity();
        }

        // ulozeni nove verze 
        public string AddVersion(VersionEntity versionToDB)
        {
            VersionEntityDB versionDB = new VersionEntityDB(versionToDB.Name);
            return versionsRepository.AddVersion(versionDB);
        }

    }
}