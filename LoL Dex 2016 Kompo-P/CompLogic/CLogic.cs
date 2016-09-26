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

        public string[,] GetChampnames()
        {
            string test = _iDatabase.DataSet().Tables["Champs"].Rows[0].ItemArray[1].ToString();
            int length = _iDatabase.DataSet().Tables["Champs"].Rows.Count;
            string[,] champnames = new string[length,2];

            for(int i = 0; i < length; i++)
            {
                champnames[i,0] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[0].ToString();
                champnames[i,1] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[1].ToString();
            }

            return champnames;
        }

        public string GetChampStats(int id)
        {
            return _iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[0].ToString();
        }
        #endregion
    }
}