using System;
using System.Collections.Generic;
using System.Data;

namespace CompLogic
{

    public interface ILogic
    {
        #region Champs
        string[,] GetChampNames();

        string GetChampInfos(int id, int infonumber);

        List<List<object>> GetAbilitiesData(int id);

        object GetChampIcon(int id);
        #endregion

        #region Items
        string[,] GetItemNames();

        string GetItemInfos(int id, int infonumber);

        object GetItemIcon(int id);

        List<object> GetIconsforParentitems(int id);
        #endregion

        #region Runes
        #endregion
    }
}
