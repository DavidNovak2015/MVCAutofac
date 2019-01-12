using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestovaciAutofacDB.DbEntities
{
    public class VersionEntityDB
    {
        public string Name { get;  set; }

        // vypis verzi z databaze
        public VersionEntityDB(string name)
        {
            Name = name;
        }

        //pro XMLSerializer
        public VersionEntityDB()
        { }
    }
}