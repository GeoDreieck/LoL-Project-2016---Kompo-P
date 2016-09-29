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

        #region Implementierung der Abstrakte Methoden SQL Befehle sind DB spezifisch
        internal override string GetSqlGetMake()
        {
            return "SELECT DISTINCT hersteller FROM autos ORDER BY hersteller;";
        }

        internal override string GetSqlGetModel(string make)
        {
            return string.Format(
                "SELECT DISTINCT modell FROM autos WHERE hersteller='{0}' ORDER BY modell;", make);
        }
        
        #endregion

        #region Implementierung Schnittstellenmethoden

        #endregion

    }
}
