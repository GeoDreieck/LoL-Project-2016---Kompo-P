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
    internal class Testclass
    {
        #region fields
        // CompUI
        IForms _overview;

        // CompLogic
        private ILogic _iLogic;
        // CompData
        private IDatabase _iDatabase;
        #endregion

        void Run()
        {
            //Test ob die Datenbank erzeugt werden kann
            var connectionString = Properties.Settings.Default.LoL_Dex_2016_DatabaseConnectionString;
            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);
            try
            {
                _iDatabase.Open();
            }
            catch
            {
                throw new Exception("Database couldn`t be opened!");
            }

            DbDataReader dbDataReader;

            string sql;

            DataSet dataSet = new DataSet();

            //test ob die Logic-Schicht erstellt werden kann
            try
            {
                string imagedirectory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName + "\\Images\\";
                _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase, imagedirectory);
            }
            catch
            {
                throw new Exception("Couldn`t get current directory!");
            }
            
            

            //Test ob Overview erzeugt werden kann.
            _overview = AFactoryIForms.CreateInstance("Overview", _iLogic);

            //Test ob Daten aus der Datenbank laden
            try
            {
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
            }
            catch
            {
                throw new Exception("Couldn`t get a Table from Database.");
            }

            //Test ob alle Forms geöffnet werden können und wieder schließen.
            string formname = "empty";
            IForms cr;

            formname = "Creeps";
            try
            {
                cr = AFactoryIForms.CreateInstance("Creeps", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
            }

            formname = "Champions";
            try
            {
                cr = AFactoryIForms.CreateInstance("Champions", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
            }

            formname = "Masteries";
            try
            {
                cr = AFactoryIForms.CreateInstance("Masteries", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
            }

            formname = "Runes";
            try
            {
                cr = AFactoryIForms.CreateInstance("Runes", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
            }

            formname = "Items";
            try
            {
                cr = AFactoryIForms.CreateInstance("Items", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
            }

            formname = "Summoner_Spells";
            try
            {
                cr = AFactoryIForms.CreateInstance("Summoner_Spells", _iLogic);
                cr.Show();
                cr.Close();
            }
            catch
            {
                throw new Exception("Couldn`t open form " + formname);
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

            new Testclass().Run();
        }
    }
}
