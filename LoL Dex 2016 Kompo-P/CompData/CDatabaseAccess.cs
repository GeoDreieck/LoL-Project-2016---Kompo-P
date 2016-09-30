/*
 * CDatabaseAccess erbt von ADatabase und darüber von IDatabase.
 * CDatabaseAccess besteht nur aus einem ctor.
 */

using System;
using System.Collections.Generic;
using System.Data;

namespace CompData
{
    internal class CDatabaseAccess : ADatabase
    {
        #region ctor
        internal CDatabaseAccess(string connectionString)
        {
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionString + ";";
            string providerString = "System.Data.OleDb"; // Name .NET DB Provider
            this.Create(connectionString, providerString);
        }
        #endregion
    }
}
