/*
 *AFactoryILogic ist die Factoryklasse, die CLogic erstellt und mit Hilfe von ILogic kapselt.
 *AFActoryILogic übergibt CLogic ein IDatabase-Object und einen String.
 */

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

        public static ILogic CreateInstance(string sDataType, IDatabase iDatabase, string imgdirpath)
        {

            switch (sDataType)
            {
                case ("CLogic"): return new CLogic(iDatabase, imgdirpath);
                default: throw new Exception(string.Format("{0} kann nicht erzeugt werden", sDataType));
            }
        }
    }
}
