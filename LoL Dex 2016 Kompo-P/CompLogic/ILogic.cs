using System;
using System.Collections.Generic;
using System.Data;

namespace CompLogic
{

    public interface ILogic
    {
        #region get/set
        string Imagdirectorypath();
        #endregion

        #region Champs
        string[,] GetChampNames();

        string GetChampInfos(int id, int infonumber);

        List<List<object>> GetAbilitiesData(int id);
        #endregion

        #region Items
        string[,] GetItemNames();

        string GetItemInfos(int id, int infonumber);

        List<string> GetIconsforParentitems(int id);
        #endregion

        #region Runes
        #endregion
    }
}
