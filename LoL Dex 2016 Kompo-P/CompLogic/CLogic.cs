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

        public void SelectCar(int iCar, ref DataTable datatable)
        {
            //_iDatabase.SelectCar(iCar, ref datatable);
        }

        public void InsertCar(int iCar)
        {
            //_iDatabase.InsertCar(iCar);
        }
        #endregion
    }
}
