using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CompLogic;

namespace CompUI
{
    public abstract class AFactoryIForms
    {

        public static IForms CreateInstance(string sDataType, ILogic iLogic)
        {

            switch (sDataType)
            {
                case ("Champions"):         return new Champions(iLogic);
                case ("Creeps"):            return new Creeps(iLogic);
                case ("Feelds"):            return new Fields(iLogic);
                case ("Items"):             return new Items(iLogic);
                case ("Overview"):          return new Overview(iLogic);
                case ("Runes"):             return new Runes(iLogic);
                case("Search"):             return new Search(iLogic);
                case ("Summoner_Spells"):   return new Summoner_Spells(iLogic);
                case ("Tipps"):             return new Tipps(iLogic);
                default: throw new Exception(string.Format("{0} kann nicht erzeugt werden", sDataType));
            }
        }

    }
}
