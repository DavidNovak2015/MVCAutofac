﻿using System.Collections.Generic;
using TestovaciAutofacDB.DbEntities;

namespace TestovaciAutofacDB.Interfaces
{
    public interface IversionsRepository
    {
        // vráti dnesni verze
        List<VersionEntityDB> GetTodaysVersions();

        // ulozi novou verzi
        string AddVersion(VersionEntityDB versionToDB);

        //vrati vsechny verze
        List<VersionEntityDB> GetAllVersions();

        //vrati pozadovanou verzi
        VersionEntityDB GetSelectedVersion(VersionEntityDB selectedVersion);
    }
}
