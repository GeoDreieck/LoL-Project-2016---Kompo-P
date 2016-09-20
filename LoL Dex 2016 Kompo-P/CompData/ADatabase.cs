using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CompData
{
    internal abstract class ADatabase : IDatabase
    {

        #region fields
        // Objektvariable
        protected string connectionString;
        protected DbConnection _dbConnection;

        protected DbCommand _dbCommandSelect;
        protected DbCommand _dbCommandInsert;
        protected DbCommand _dbCommandUpdate;
        protected DbCommand _dbCommandDelete;

        protected string providerString;
        private DbProviderFactory _dbProviderFactory;
        #endregion

        #region ctor
        internal ADatabase() { }
        #endregion

        #region Abstrakte Methoden SQL Befehle sind DB spezifisch
        internal abstract string GetSqlGetMake();
        internal abstract string GetSqlGetModel(string make);
        #endregion

        #region Interface Implmentierung Allgemein


        #endregion

        

        #region Interface Implementierung Connected
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

        public void Close()
        {
            if (_dbConnection.State == ConnectionState.Open)
                _dbConnection.Close();
        }

        public virtual object ExecuteScalar(string sql)
        {
            _dbCommandSelect.CommandText = sql;
            object obj = _dbCommandSelect.ExecuteScalar();
            return obj;
        }

        public virtual DbDataReader ExecuteQuery(string sql)
        {
            // preconditions
            //  if( sql == string.Empty )

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

        #region Interface Implementierung Disconnected

        public virtual DbDataAdapter CreateDbDataAdapter(string dataTableName)
        {

            DbDataAdapter dbDataAdapter = _dbProviderFactory.CreateDataAdapter();

            DbCommandBuilder dbCommandBuilder = _dbProviderFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = dbDataAdapter;  // Dependency Injection

            // Select DbCommand
            DbCommand dbCommandSelect = _dbProviderFactory.CreateCommand();
            dbCommandSelect.Connection = _dbConnection;
            dbCommandSelect.CommandText = "SELECT * FROM " + dataTableName;

            dbDataAdapter.SelectCommand = dbCommandSelect;  // SELECT ohne joins muss von Benutzer definiert
            dbDataAdapter.InsertCommand = dbCommandBuilder.GetInsertCommand(); // INSERT wird generiert
            dbDataAdapter.UpdateCommand = dbCommandBuilder.GetUpdateCommand(); // INSERT wird generiert
            dbDataAdapter.DeleteCommand = dbCommandBuilder.GetDeleteCommand(); // INSERT wird generiert

            return dbDataAdapter;
        }

        public virtual int Fill(string sql, DataTable dataTable, DbDataAdapter dbDataAdapter)
        {
            // preconditions
            if (sql == string.Empty)
                throw new Exception(" ADatabase.Fill() sql string is empty or null");
            if (dataTable == null)
                throw new Exception(" ADatabase.Fill() dataTable is null");
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.Fill() dbDataAdapter is null");
            int nRows = 0;
            try
            {
                dbDataAdapter.SelectCommand.CommandText = sql;
                nRows = dbDataAdapter.Fill(dataTable);
                // post condition is nRows == 0 zulässig?
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.Fill() {0} fails\n", sql) + exception.Message;
                throw new Exception(message);
            }
            return nRows;
        }

        public virtual int Update(DataTable dataTable)
        {
            // preconditions
            if (dataTable == null)
                throw new Exception(" ADatabase.Fill() dataTable is null");

            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter(dataTable.TableName);
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.Fill() dbDataAdapter is null");

            int nRows = 0;
            try
            {
                nRows = dbDataAdapter.Update(dataTable);
                // post condition is nRows == 0 zulässig?
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.Update() fails\n") + exception.Message;
                throw new Exception(message);
            }
            return nRows;
        }


        public virtual DataTable GetSchema(string dataTableName)
        {
            // preconditions
            if (dataTableName == string.Empty)
                throw new Exception(" ADatabase.GetSchema() dataTableName is empty or null");

            DbDataAdapter dbDataAdapter = this.CreateDbDataAdapter(dataTableName);
            if (dbDataAdapter == null)
                throw new Exception(" ADatabase.Fill() dbDataAdapter is null");

            try
            {
                DataTable dataTable = new DataTable();
                dataTable = dbDataAdapter.FillSchema(dataTable, SchemaType.Source);
                return dataTable;
            }
            catch (Exception exception)
            {
                string message = string.Format("ADatabase.GetSchema() {0} fails\n") + exception.Message;
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

                _dbCommandInsert = this.CreateCommand(_dbConnection);
                _dbCommandUpdate = this.CreateCommand(_dbConnection);
                _dbCommandDelete = this.CreateCommand(_dbConnection);
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

