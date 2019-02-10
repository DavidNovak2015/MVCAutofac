using TestovaciAutofac.Models.Entities;

namespace TestovaciAutofac.Interfaces
{
    public interface IselectionMaskViewModel
    {
        //nastavi vyhledavaci masku
        void GetSelectionMask();
        
        //vrati pozadovanou verzi
        void GetSelectedVersion(VersionEntity selectedVersion);
    }
}
