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