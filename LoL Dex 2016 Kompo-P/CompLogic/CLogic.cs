using System;
using System.Collections.Generic;
using System.Data;

using CompData;


namespace CompLogic
{

    internal class CLogic : ILogic
    {

        #region fields
        private IDatabase _iDatabase;
        #endregion

        #region ctor
        // Dependency injection ctor
        public CLogic(IDatabase iDatabase)
        {
            _iDatabase = iDatabase;
        }
        #endregion

        #region methods
        // Implmentierung Interfaces

        #region Champs
        public string[,] GetChampNames()
        {
            int length = _iDatabase.DataSet().Tables["Champs"].Rows.Count;
            string[,] champnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                champnames[i, 0] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[0].ToString();
                champnames[i, 1] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[1].ToString();
            }

            return champnames;
        }

        public string GetChampInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[infonumber + 1].ToString();
        }

        public List<List<object>> GetAbilitiesData(int id)
        {
            List<List<object>> abilitylist = new List<List<object>>();
            int firstAbilityID = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[5].ToString());
            int numberofAbilitys = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[6].ToString());

            List<object> ability = new List<object>();

            for (int i = 0; i < numberofAbilitys; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    ability.Add(_iDatabase.DataSet().Tables["Abilities"].Rows[firstAbilityID + i2].ItemArray[i2 + 1]);
                }
                abilitylist.Add(ability);
                ability.Clear();
            }

            return abilitylist;
        }

        public object GetChampIcon(int id)
        {
            return _iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[7];
        }
        #endregion

        #region Items
        public string[,] GetItemNames()
        {
            int length = _iDatabase.DataSet().Tables["Items"].Rows.Count;
            string[,] itemnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                itemnames[i, 0] = _iDatabase.DataSet().Tables["Items"].Rows[i].ItemArray[0].ToString();
                itemnames[i, 1] = _iDatabase.DataSet().Tables["Items"].Rows[i].ItemArray[1].ToString();
            }

            return itemnames;
        }

        public string GetItemInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Items"].Rows[id].ItemArray[infonumber + 1].ToString();
        }

        public object GetItemIcon(int id)
        {
            return _iDatabase.DataSet().Tables["Items"].Rows[id].ItemArray[5];
        }

        public List<object> GetIconsforParentitems(int id)
        {
            List<object> iconlist = new List<object>();
            DataRow[] result = _iDatabase.DataSet().Tables["Items"].Select("ItemAID == id");

            for(int i = 0; i < result.Length; i++)
            {
                iconlist.Add(_iDatabase.DataSet().Tables["Items"].Rows[Convert.ToInt32(result[i].ItemArray[2].ToString())].ItemArray[5]);
            }

            return iconlist; 
        }
        #endregion

        #region Runes

        #endregion

        #endregion
    }
}