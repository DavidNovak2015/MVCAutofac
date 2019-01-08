using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TestovaciAutofacDB.DbEntities;
using TestovaciAutofacDB.Interfaces;


namespace TestovaciAutofacDB.DbRepositories
{
    public class VersionsRepository:IversionsRepository
    {
        private const string path = "D:/RODINA-zalohaDavidMiriamNoe/David/Programovani/MVCProjects/TestovaciAutofac/TestovaciAutofac/DbFiles";
        private const string path1 = "C:/Users/David/Desktop/David/Programovani/MVCProjects/TestovaciAutofac/TestovaciAutofac/DbFiles";
        private string result = "";
        private List<VersionEntityDB> error = new List<VersionEntityDB>();

        //vlozi data do Listu za ucelem ulozeni do souboru
        private List<VersionEntityDB> GetListOfRecords(VersionEntityDB versionToDB)
        {
            List<VersionEntityDB> records = new List<VersionEntityDB>();
            records.Add(versionToDB);
            return records;
        }

        // vráti dnesni verze
        public List<VersionEntityDB> GetTodaysVersions()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<VersionEntityDB>));
                using (StreamReader reader = new StreamReader($"{path1}/verze"))
                {
                    return (List<VersionEntityDB>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                error.Add(new VersionEntityDB($"Požadavek nebyl proveden. Popis chyby:\n\n {ex.Message.ToString()}"));
                return error;
            }
        }

        // ulozi novou verzi
        public string AddVersion(VersionEntityDB versionToDB)
        {
            List<VersionEntityDB> savedVersions = GetTodaysVersions();
            savedVersions.Add(versionToDB);

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<VersionEntityDB>));
                using (StreamWriter streamWriter = new StreamWriter($" {path1}/verze"))
                {
                    serializer.Serialize(streamWriter, savedVersions );
                }
                return result = "Požadavek byl proveden";
            }
            catch (Exception ex)
            {
                return result=$"Požadavek nebyl proveden. Popis chyby: \n\n {ex.Message.ToString()}";
            }
        }

        //vrati vsechny verze
        public List<VersionEntityDB> GetAllVersions()
        {
            return GetTodaysVersions();
        }
    }
}
