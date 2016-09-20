using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CompData
{
    public interface IDatabase
    {

        /*int CountCars();
        object[] GetMake();
        object[] GetModel(string make);*/

        void Open();
        void Close();
        // ToDo CRUD
        object ExecuteScalar(string sql);
        DbDataReader ExecuteQuery(string sql);

        DbDataAdapter CreateDbDataAdapter(string sql);
        int Fill(string sql, DataTable dataTable, DbDataAdapter dbDataAdapter);

    }
}
