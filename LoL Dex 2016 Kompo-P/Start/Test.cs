using System;
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
        Form _overview;

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

            // Anzahl Champs in DB
            int nChamps = (int)_iDatabase.ExecuteScalar("SELECT COUNT(*) FROM Champions;");

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

            // Overview starten
            
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
