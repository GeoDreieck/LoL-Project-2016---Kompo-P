﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;

using CompUI;
using CompLogic;
using CompData;
using System.Data;

namespace Test
{
    class Test
    {

        #region fields
        // CompUI
        private IForms _champions;
        private IForms _creeps;
        private IForms _fields;
        private IForms _items;
        private IForms _overview;
        private IForms _runes;
        private IForms _search;
        private IForms _summoner_spells;
        private IForms _tipps;

        // CompLogic
        private ILogic _iLogic;
        // CompData
        private IDatabase _iDatabase;
        // CompUtils
        #endregion

        void Run1()
        {
            var connectionString = Start.Properties.Settings.Default.LoL_Dex_2016_DatabaseConnectionString;

            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);
            _iDatabase.Open();

            // Anzahl Fahrzeuge in DB
            int nCars = (int)_iDatabase.ExecuteScalar("SELECT COUNT(*) FROM Champions;");

            /*
            // Liste der Hersteller ---------------------------------------------------------------------------------------
            DbDataReader dbDataReader = _iDatabase.ExecuteQuery("SELECT DISTINCT name FROM Champions ORDER BY name;");
            // Schleife über ResultSet
            List<object> listMake = new List<object>();
            while (dbDataReader.Read())
            {
                listMake.Add(dbDataReader[0]);
            }
            dbDataReader.Close();

            object[] objMake = listMake.ToArray(); // UI Control braucht Liste von Objekten

            */

            DbDataReader dbDataReader = _iDatabase.ExecuteQuery("SELECT * FROM Champions ORDER BY name;");
            DataTable dataTable = new DataTable("Champions");
            dataTable.Load(dbDataReader);
            dbDataReader.Close();
            // Anzahl Zeilen
            int nRows = dataTable.Rows.Count;
            int nColumns = dataTable.Columns.Count;
            foreach (DataRow row in dataTable.Rows)
            {
                object o = row[0];
            }

        }


        void Run2()
        {
            // Unterste Schicht CompData wird zuerst erzeugt
            var connectionString = Start.Properties.Settings.Default.LoL_Dex_2016_DatabaseConnectionString;
            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);

            // Mittlere Schicht CompLogic wird es zweites erzugt
            _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase);

            // Oberste Schicht CompUI
            _champions = AFactoryIForms.CreateInstance("Champions", _iLogic);
            _creeps = AFactoryIForms.CreateInstance("Creeps", _iLogic);
            _fields = AFactoryIForms.CreateInstance("Fields", _iLogic);
            _items = AFactoryIForms.CreateInstance("Items", _iLogic);
            _overview = AFactoryIForms.CreateInstance("Overview", _iLogic);
            _runes = AFactoryIForms.CreateInstance("Runes", _iLogic);
            _search = AFactoryIForms.CreateInstance("Search", _iLogic);
            _summoner_spells = AFactoryIForms.CreateInstance("Summoner_Spells", _iLogic);
            _tipps = AFactoryIForms.CreateInstance("Tipps", _iLogic);

            // CDialogMain starten
            
                Application.Run(_overview as Form);
            
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Test().Run2();
            Console.ReadKey();
        }
    }
}
