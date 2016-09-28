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
        string _imagedirectorypath;
        #endregion

        #region ctor
        // Dependency injection ctor
        public CLogic(IDatabase iDatabase, string imgdirpath)
        {
            _iDatabase = iDatabase;
            _imagedirectorypath = imgdirpath;
        }
        #endregion

        #region get/set
        public string Imagdirectorypath()
        {
            return _imagedirectorypath;
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
            return _iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[infonumber].ToString();
        }

        public List<List<string>> GetAbilitiesData(int id)
        {
            List<List<string>> abilitylist = new List<List<string>>();
            int firstAbilityID = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[4].ToString());
            int numberofAbilitys = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[5].ToString());

            for (int i = 0; i < numberofAbilitys; i++)
            {
                List<string> ability = new List<string>();
                for (int i2 = 0; i2 < 5; i2++)
                {
                    ability.Add(_iDatabase.DataSet().Tables["Abilities"].Rows[firstAbilityID + i].ItemArray[i2 + 1].ToString());
                }
                abilitylist.Add(ability);
            }

            return abilitylist;
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
            return _iDatabase.DataSet().Tables["Items"].Rows[id].ItemArray[infonumber].ToString();
        }

        public List<string> GetIconsforParentitems(int id)
        {
            List<string> iconlist = new List<string>();
            DataRow[] result = _iDatabase.DataSet().Tables["ItemAbuildsIntoItemB"].Select("ItemAID = " + id);

            for(int i = 0; i < result.Length; i++)
            {
                iconlist.Add(_iDatabase.DataSet().Tables["Items"].Rows[Convert.ToInt32(result[i].ItemArray[1].ToString())-1].ItemArray[5].ToString());
            }

            return iconlist; 
        }
        #endregion

        #region Runes
        public string[,] GetAllRunesNames()
        {
            int length = _iDatabase.DataSet().Tables["Runes"].Rows.Count;
            string[,] runesnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                runesnames[i, 0] = _iDatabase.DataSet().Tables["Runes"].Rows[i].ItemArray[0].ToString();
                runesnames[i, 1] = _iDatabase.DataSet().Tables["Runes"].Rows[i].ItemArray[1].ToString();
            }

            return runesnames;
        }

        public string[,] GetSelectedRunesNames(string kind, string level)
        {
            int length;

            DataRow[] result = _iDatabase.DataSet().Tables["Runes"].Select("RuneKind ==" + kind + " && TierLevel ==" + level);
            length = result.Length;

            string[,] RunesNamesIDPairArray = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                RunesNamesIDPairArray[i, 0] = result[i].ItemArray[0].ToString();
                RunesNamesIDPairArray[i, 1] = result[i].ItemArray[1].ToString();
            }

            return RunesNamesIDPairArray;
        }

        public string GetRunesInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Runes"].Rows[id].ItemArray[infonumber].ToString();
        }
        #endregion

        #region Masterie
        public string GetTree(int treenumber)
        {
            return _iDatabase.DataSet().Tables["Masterietrees"].Rows[0].ItemArray[treenumber].ToString();
        }
        #endregion

        #endregion
    }
}