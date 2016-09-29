using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using System.IO;

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
            string imagedirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName + "\\Images\\";
            _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase, imagedirectory);

            _overview = AFactoryIForms.CreateInstance("Overview", _iLogic);

            // Oberste Schicht CompUI

            //Daten aus der Datenbank laden
            sql = string.Format("SELECT * FROM Champs;");
            DataTable dataTableChamps = new DataTable("Champs");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableChamps.Load(dbDataReader);
            dbDataReader.Close();
            dataTableChamps.DefaultView.Sort = "ID";
            dataTableChamps = dataTableChamps.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableChamps);

            sql = string.Format("SELECT * FROM Abilities;");
            DataTable dataTableAbilities = new DataTable("Abilities");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableAbilities.Load(dbDataReader);
            dbDataReader.Close();
            dataTableAbilities.DefaultView.Sort = "ID";
            dataTableAbilities = dataTableAbilities.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableAbilities);

            sql = string.Format("SELECT * FROM Items;");
            DataTable dataTableItems = new DataTable("Items");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableItems.Load(dbDataReader);
            dbDataReader.Close();
            dataTableItems.DefaultView.Sort = "ID";
            dataTableItems = dataTableItems.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableItems);

            sql = string.Format("SELECT * FROM Runes;");
            DataTable dataTableRunes = new DataTable("Runes");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableRunes.Load(dbDataReader);
            dbDataReader.Close();
            dataTableRunes.DefaultView.Sort = "ID";
            dataTableRunes = dataTableRunes.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableRunes);

            sql = string.Format("SELECT * FROM ItemAbuildsIntoItemB;");
            DataTable dataTableItemAbuildsIntoItemB = new DataTable("ItemAbuildsIntoItemB");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableItemAbuildsIntoItemB.Load(dbDataReader);
            dbDataReader.Close();
            _iDatabase.AddTabletoDataSet(dataTableItemAbuildsIntoItemB);

            sql = string.Format("SELECT * FROM Masterie;");
            DataTable dataTableMasterie = new DataTable("Masterie");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableMasterie.Load(dbDataReader);
            dbDataReader.Close();
            dataTableMasterie.DefaultView.Sort = "ID";
            dataTableMasterie = dataTableMasterie.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableMasterie);

            sql = string.Format("SELECT * FROM Masterietrees;");
            DataTable dataTableMasterietrees = new DataTable("Masterietrees");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableMasterietrees.Load(dbDataReader);
            dbDataReader.Close();
            dataTableMasterietrees.DefaultView.Sort = "ID";
            dataTableMasterietrees = dataTableMasterietrees.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableMasterietrees);

            sql = string.Format("SELECT * FROM SummonerSpells;");
            DataTable dataTableSummonerSpells = new DataTable("SummonerSpells");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableSummonerSpells.Load(dbDataReader);
            dbDataReader.Close();
            dataTableSummonerSpells.DefaultView.Sort = "ID";
            dataTableSummonerSpells = dataTableSummonerSpells.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableSummonerSpells);

            sql = string.Format("SELECT * FROM Creeps;");
            DataTable dataTableCreeps = new DataTable("Creeps");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableCreeps.Load(dbDataReader);
            dbDataReader.Close();
            dataTableCreeps.DefaultView.Sort = "ID";
            dataTableCreeps = dataTableCreeps.DefaultView.ToTable();
            _iDatabase.AddTabletoDataSet(dataTableCreeps);

            //GetChampNames Test
            string[,] testarray = _iLogic.GetChampNames();
            for(int i = 0; i < (testarray.Length/2); i++)
            {
                Console.WriteLine(testarray[i,0] + ": " + testarray[i,1]);
            }

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
