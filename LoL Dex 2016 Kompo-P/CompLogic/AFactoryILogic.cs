using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CompData;


namespace CompLogic
{
    public abstract class AFactoryILogic
    {

        public static ILogic CreateInstance(string sDataType, IDatabase iDatabase)
        {

            switch (sDataType)
            {
                case ("CLogic"): return new CLogic(iDatabase);
                default: throw new Exception(string.Format("{0} kann nicht erzeugt werden", sDataType));
            }
        }
    }
}
