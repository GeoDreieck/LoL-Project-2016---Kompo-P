using System;
using System.Collections.Generic;
using System.Data;

namespace CompLogic
{

    public interface ILogic
    {

        void SelectCar(int iCar, ref DataTable dataTable);
        void InsertCar(int iCar);
    }
}
