using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
