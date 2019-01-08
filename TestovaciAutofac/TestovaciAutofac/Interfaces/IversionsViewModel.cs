using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestovaciAutofac.Models.Entities;

namespace TestovaciAutofac.Interfaces
{
    public interface IversionsViewModel
    {
        void GetTodaysVersions();
        void AddForm();
        string AddVersion(VersionEntity versionToDB);
    }

}
