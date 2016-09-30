using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CompData
{
    internal abstract class ADatabase : IDatabase
    {
        //Erzeugen von Klassenspezifischen Variablen
        #region fields
        protected string connectionString;
        protected DbConnection _dbConnection;

        protected DbCommand _dbCommandSelect;

        protected string providerString;
        private DbProviderFactory _dbProviderFactory;

        private DataSet dataSet = new DataSet();
        #endregion

        #region get/set
        //Return dataSet
        public DataSet DataSet()
        {
            return dataSet;
        }
        #endregion

        #region ctor
        internal ADatabase() { }
        #endregion

        #region Interface Implmentierung Allgemein
        //Fügt einen Table dem Dataset hinzu
        public void AddTabletoDataSet(DataTable dataTable)
        {
            dataSet.Tables.Add(dataTable);
        }
        #endregion

        #region Interface Implementierung Connected
        //Öffnen der Datenbankverbindung
        public void Open()
        {
            // Ist die Db schon geöffent -> nichts tun
            if (_dbConnection.State != ConnectionState.Open)
            {
                // DB öffnen
                _dbConnection.Open();
                // Test ob DB jetz offen ist
                if (_dbConnection.State != ConnectionState.Open)
                {
                    return;
                }
            }
        }

        //Schließen der Datenbankverbindung
        public void Close()
        {
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        //Executy Select-Command
        public virtual DbDataReader ExecuteQuery(string sql)
        {
            DbDataReader dbDataReader = null;
            try
            {
                _dbCommandSelect.CommandText = sql;
                dbDataReader = _dbCommandSelect.ExecuteReader();
                return dbDataReader;
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.ExecuteQuery() {0} fails\n", sql) + exception.Message;
                throw new Exception(message);
            }
        }
        #endregion

        #region interne Methoden
        internal void Create(string connectionString, string providerString)
        {
            // preconditions
            if (connectionString == string.Empty)
                throw new NullReferenceException("ADatabase.Create() ConnectionString is null");
            if (providerString == string.Empty)
                throw new NullReferenceException("ADatabase.Create() ConnectionString is null");
            try
            {
                _dbProviderFactory = DbProviderFactories.GetFactory(providerString); // Provider
                if (_dbProviderFactory == null)
                    throw new NullReferenceException("ADatabase.Create() fails _dbProviderFactory is null");

                _dbConnection = _dbProviderFactory.CreateConnection();
                if (_dbConnection == null)
                    throw new NullReferenceException("ADatabase.Create() fails _dbConnection is null");
                _dbConnection.ConnectionString = connectionString; //

                _dbCommandSelect = this.CreateCommand(_dbConnection);
            }
            catch (Exception exception)
            {
                throw new DataException(
                    string.Format("ADatabase.Create() fails\nConnectionString:{0}\nProviderString:{1}\n{2}",
                    connectionString, providerString, exception));
            }
        }

        private DbCommand CreateCommand(DbConnection dbConnection)
        {
            DbCommand dbCommand = _dbProviderFactory.CreateCommand();
            if (dbCommand == null)
                throw new NullReferenceException("ADatabase.Create() fails _dbConnection is null");

            dbCommand.Connection = dbConnection;
            dbCommand.CommandTimeout = 30;
            return dbCommand;
        }
        #endregion

    }
}

