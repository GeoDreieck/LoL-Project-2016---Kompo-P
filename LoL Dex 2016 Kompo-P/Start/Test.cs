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

        void Run()
        {
            // Unterste Schicht CompData wird zuerst erzeugt
            var connectionString = Start.Properties.Settings.Default.LoL_Dex_2016_DatabaseConnectionString;
            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);
            _iDatabase.Open();

            DbDataReader dbDataReader;

            string sql;

            DataSet dataSet = new DataSet();

            // Mittlere Schicht CompLogic wird es zweites erzugt
            _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase);

            _overview = AFactoryIForms.CreateInstance("Overview", _iLogic);

            // Oberste Schicht CompUI

            //Daten aus der Datenbank laden
            sql = string.Format("SELECT * FROM Champs;");
            DataTable dataTableChamps = new DataTable("Champs");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableChamps.Load(dbDataReader);
            dbDataReader.Close();
            _iDatabase.AddTabletoDataSet(dataTableChamps);

            sql = string.Format("SELECT * FROM Abilities;");
            DataTable dataTableAbilities = new DataTable("Abilities");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableAbilities.Load(dbDataReader);
            dbDataReader.Close();
            _iDatabase.AddTabletoDataSet(dataTableAbilities);

            // Overview starten
            Application.Run(_overview as Form);

            _iDatabase.Close();
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Test().Run();
        }
    }
}
