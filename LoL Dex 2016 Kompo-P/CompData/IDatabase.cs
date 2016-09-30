/*
 * IDatabase ist ein Interface, das Funktionen definiert, die von ADatabase implementiert werden müssen.
 * IDatabase kapselt CDatabaseAccess.
 */

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
        
        DbDataReader ExecuteQuery(string sql);

        void AddTabletoDataSet(DataTable dataTable);
    }
}
