using TestovaciAutofac.Models.Entities;

namespace TestovaciAutofac.Interfaces
{
    public interface IversionsViewModel
    {
        // vrati dnesni verze
        void GetTodaysVersions();

        // zobrazeni prazdneho formulare
        void AddForm();

        // ulozeni nove verze 
        string AddVersion(VersionEntity versionToDB);
    }

}
