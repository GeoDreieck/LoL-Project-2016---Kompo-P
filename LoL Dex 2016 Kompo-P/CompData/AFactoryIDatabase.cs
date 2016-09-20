using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CompData
{
    public abstract class AFactoryIDatabase
    {

        public static IDatabase CreateInstance(string type, string connectionString)
        {
            switch (type)
            {
                case "CDatabaseAccess": { return new CDatabaseAccess(connectionString); }
                default: return null;
            }
        }
    }
}
