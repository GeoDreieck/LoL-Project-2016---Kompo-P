using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CompData
{
    public interface IDatabase
    {
        DataSet DataSet();

        void Open();
        void Close();
        
        object ExecuteScalar(string sql);
        DbDataReader ExecuteQuery(string sql);

        DbDataAdapter CreateDbDataAdapter(string sql);
        int Fill(string sql, DataTable dataTable, DbDataAdapter dbDataAdapter);

        void AddTabletoDataSet(DataTable dataTable);

    }
}
