/*
 * Main(string[] args) ist der Einstiegspunkt in das Programm.
 * Run() wird von der Main-Methode aufgerufen und initialisiert zuerst die Data-Schicht.
 * Danach wird die Logic-Schicht initialisiert indem AFactoryILogic aufgerufen und ihr die zuvor initialisierte Data-Schicht übergeben wird.
 * Nach der Logic-Schicht wird die Haupt-Form Overview als erste Form derView-Schicht erzeugt, welche als Hub fungiert von dem die anderen Forms gestartet werden.
 * Nachdem Overview erzeugt wurde werden alle relevanten Tables aus der Datenbank in ein lokales DataSet geladen um einen schnelleren Zugriff zu gewährleisten.
 * Zuletzt werden Overview als Haupt-Forms gestartet und nach dem schließen dieser die Datenbank-Verbindung geschlossen.
 */

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

namespace LoL_Dex_2016
{
    class Start
    {
        #region fields
        // CompUI
        Form _overview;

        // CompLogic
        private ILogic _iLogic;
        // CompData
        private IDatabase _iDatabase;
        #endregion

        void Run()
        {
            // Unterste Schicht CompData wird zuerst erzeugt
            string connectionstringrelease = Directory.GetCurrentDirectory() + "\\LoL Dex 2016 Database.mdb";
            var connectionStringdebug = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName + "\\LoL Dex 2016 Database.mdb";
            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionstringrelease);
            _iDatabase.Open();

            // Für CompData wird alles erzeugt, was zum lokalem Abspeichern der DB notwendig ist.
            DbDataReader dbDataReader;
            string sql;
            DataSet dataSet = new DataSet();

            // Mittlere Schicht CompLogic wird es zweites erzugt
            string imagedirectoryrelease = Directory.GetCurrentDirectory() + "\\Images\\";
            string imagedirectorydebug = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName + "\\Images\\";
            _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase, imagedirectoryrelease);

            // Oberste Schicht CompUI
            _overview = AFactoryIForms.CreateInstance("Overview", _iLogic);

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

            // Overview starten
            Application.Run(_overview as Form);

            _iDatabase.Close();
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Start().Run();
        }
    }
}