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

namespace Start
{
    class Start
    {
        /*
        #region fields
        // CompUI

        // CompLogic
        private ILogic _iLogic;
        // CompData
        private IDatabase _iDatabase;
        #endregion

        void Run1()
        {
            var connectionString = LoL_Dex_2016.Properties.Settings.Default.LoL_Dex_2016_DatabaseConnectionString;

            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);
            _iDatabase.Open();

            // Anzahl Fahrzeuge in DB
            int nCars = (int)_iDatabase.ExecuteScalar("SELECT COUNT(*) FROM autos;");

            // Liste der Hersteller ---------------------------------------------------------------------------------------
            DbDataReader dbDataReader = _iDatabase.ExecuteQuery("SELECT DISTINCT hersteller FROM autos ORDER BY hersteller;");
            // Schleife über ResultSet
            List<object> listMake = new List<object>();
            while (dbDataReader.Read())
            {
                listMake.Add(dbDataReader[0]);
            }
            dbDataReader.Close();
            object[] objMake = listMake.ToArray(); // UI Control braucht Liste von Objekten

            dbDataReader = _iDatabase.ExecuteQuery("SELECT DISTINCT hersteller FROM autos ORDER BY hersteller;");
            DataTable dataTable = new DataTable("Hersteller");
            dataTable.Load(dbDataReader);
            dbDataReader.Close();
            // Anzahl Zeilen
            int nRows = dataTable.Rows.Count;
            int nColumns = dataTable.Columns.Count;
            foreach (DataRow row in dataTable.Rows)
            {
                object o = row[0];
            }

            // Liste der Modelle ------------------------------------------------------------------------------------------
            // Herstellerauswahl
            string make = "Audi";
            // Anzahl Autos von diesem Hersteller
            string sql = string.Format("SELECT COUNT (*) FROM autos WHERE hersteller='{0}';", make);
            int nCarsByMake = (int)_iDatabase.ExecuteScalar(sql);

            //CompData
            sql = string.Format("SELECT DISTINCT modell FROM autos WHERE hersteller='{0}' ORDER BY modell;", make);
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            // Schleife über ResultSet
            //CompLogic
            List<object> listModel = new List<object>();
            while (dbDataReader.Read())
            {
                listModel.Add(dbDataReader[0]);
            }
            dbDataReader.Close();
            object[] objModel = listMake.ToArray(); // UI Control braucht Liste von Objekten
                                                    //CompUI
                                                    // Anzeigen Combobox  

            // Modellauswahl
            string model = "A4";
            sql = string.Format("SELECT COUNT (*)  FROM autos WHERE hersteller='{0}' AND modell='{1}';", make, model);
            int nCarsByMakeAndModel = (int)_iDatabase.ExecuteScalar(sql);

            // Alle Audi A4 selektieren
            sql = string.Format(
                "SELECT hersteller,modell,leistung,kraftstoff,zulassung,km,preis,plz " +
                "FROM autos WHERE hersteller='{0}' AND modell='{1}' ORDER BY preis;", make, model);
            DataTable dataTableSelectedCars = new DataTable("Cars");
            dbDataReader = _iDatabase.ExecuteQuery(sql);
            dataTableSelectedCars.Load(dbDataReader);
            dbDataReader.Close();

            // Wie geht INSERT UPDATE DELETE ???? --> seeehr aufwääändig
            dataTableSelectedCars.Clear();
            DbDataAdapter dbDataAdapter = _iDatabase.CreateDbDataAdapter("SELECT * FROM autos;");

            sql = string.Format(
            "SELECT hersteller,modell,leistung,kraftstoff,zulassung,km,preis,plz " +
            "FROM autos WHERE hersteller='{0}' AND modell='{1}' ORDER BY preis;", make, model);
            nRows = _iDatabase.Fill(sql, dataTableSelectedCars, dbDataAdapter);

            // Datensatz schreiben
            DataTable dataTableUpdate = new DataTable();
            sql = string.Format("SELECT * FROM autos;");
            nRows = _iDatabase.Fill(sql, dataTableUpdate, dbDataAdapter);
            dataTableUpdate.Clear();
            DataRow dataRow = dataTableUpdate.NewRow();
            // Spalte GUID
            Guid id = Guid.NewGuid();

            dataRow[0] = "1111111111";
            dataRow[1] = "Opel";      // Hersteller
            dataRow[2] = "Corsa";    // Modell
            dataRow[3] = 90;         // Leistung
            dataRow[4] = "Benzin";   // Kraftstoff
            dataRow[5] = 2009 - 03 - 23; // Zulassung
            dataRow[6] = 35000;      // km
            dataRow[7] = 7500;       // Preis
            dataRow[8] = 29556;      // PLZ
            dataRow[9] = -1;         // Anbieter
            dataRow[10] = "Foto.jpg";
            dataTableSelectedCars.Rows.Add(dataRow);

            dbDataAdapter.Update(dataTableUpdate);

        }


        void Run2()
        {

            // Dependency Inversion Principle (Umkehrung des Kontrollflusses)
            _iCar = AFactoryICar.CreateInstance("CCar");

            // Unterste Schicht CompData wird zuerst erzeugt
            var connectionString = Properties.Settings.Default.ConnectionStringAccess;
            _iDatabase = AFactoryIDatabase.CreateInstance("CDatabaseAccess", connectionString);

            // Mittlere Schicht CompLogic wird es zweites erzugt
            _iLogic = AFactoryILogic.CreateInstance("CLogic", _iDatabase, _iCar);

            // Oberste Schicht CompUI
            _iDialogSearch = AFactoryIForms.CreateInstance("CDialogSearch", _iLogic, _iCar);
            _iDialogSearchView = AFactoryIForms.CreateInstance("CDialogSearchView", _iLogic, _iCar);
            _iDialogSell = AFactoryIForms.CreateInstance("CDialogSell", _iLogic, _iCar);
            _iDialogMain = AFactoryIForms.CreateInstance("CDialogMain", _iLogic, _iCar) as IWindow;

            _iDialogMain.IDialogSearch = _iDialogSearch; // Dependency injection via setter
            _iDialogMain.IDialogSearchView = _iDialogSearchView;
            _iDialogMain.IDialogSell = _iDialogSell;

            // CDialogMain starten
            if (_iDialogMain is Form)
            {
                Application.Run(_iDialogMain as Form);
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Test().Run2();
            //  Console.ReadKey();
        }
        */
    }
}