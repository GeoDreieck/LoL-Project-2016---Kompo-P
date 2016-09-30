/*
 * Champions.cs implementiert den ctor und die EventHandler und Fields von dem Champions-Forms-Object.
 * Champions_Load wird beim Laden des Forms aufgerufen und Füllt die ListView und wählt das erste Item dieser aus.
 * lView_Champnames_SelectedIndexChanged wird aufgerufen, wenn sich SelectedIndices der ListView ändert. Sie sorgt dafür, dass das Icon in die PictureBox und die Stats-Infos in eine TextBox geladen werden.
 * stats_btn_Click ist das Click-Event von stats_btn und erzeugt eine Textbox in die die Stats des ausgewählten Items der ListView geladen werden.
 * story_btn_Click ist das Click-Event von story_btn und erzeugt eine Textbox in die die Story des ausgewählten Items der ListView geladen werden.
 * spells_btn_Click ist das Click-Event von spells_btn und erzeugt eine GridBox in die die Infos über die Abilitys des ausgewählten Items der ListView geladen werden.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CompLogic;

namespace CompUI
{
    public partial class Champions : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        // Erstellen einer index-Variablen um nicht immer SelectedIndex der Listview aufrufen zu müssen
        int index;
        #endregion

        public Champions(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        private void Champions_Load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] champnames = _iLogic.GetChampNames();
            ListViewItem idchampPair;

            //Listview füllen
            for(int i = 0; i < (champnames.Length/champnames.Rank); i++)
            {
                idchampPair = new ListViewItem(champnames[i, 0]);
                idchampPair.SubItems.Add(champnames[i, 1]);

                lView_Champnames.Items.AddRange(new ListViewItem[] { idchampPair });
            }

            //Erstes Item der Listview
            lView_Champnames.FindItemWithText("1").Selected = true;
            index = lView_Champnames.Items.IndexOf(lView_Champnames.SelectedItems[0]);
        }

        private void lView_Champnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Wenn kein Element der ListView ausgewählt ist, tuhe nichts;
            Fängt ab, dass beim neuen Auswählen eines ListView-Items erst alle SelectedIndices auf
            null gesetzt werden und dann mindestens ein Element in SelectedIndices eingefügt wird und damit
            zwei SelectedIndexChanged-Events aufgerufen werden
            */
            if (lView_Champnames.SelectedIndices.Count <= 0)
                return;

            //Wenn SelectedIndices nicht leer ist, setze index auf den Wert des neu ausgewählten Items,
            //lade die Stats dafür über stats_btn.PerformClick() und lade das passende Icon in die Picturebox
            if(lView_Champnames.SelectedIndices[0]>= 0)
            {
                //Weiße index den neuen Wert zu
                index = lView_Champnames.SelectedIndices[0];

                //Rufe stats_btn.PerformClick() auf
                stats_btn.PerformClick();

                //Lade das Icon zu dem ListViewItem aus dem DataSet und setze das BackGroundImage der PictureBox gleich dem Icon
                ChampIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetChampInfos(index, 6), true);
            }
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            //Cleare MainContentPanel, erzeuge und binde eine Textbox ans MainContentPanel
            MainContentPanel.Controls.Clear();
            TextBox statsstextbox = new TextBox();
            MainContentPanel.Controls.Add(statsstextbox);
            statsstextbox.Size = MainContentPanel.Size;
            statsstextbox.Name = "Stats";
            statsstextbox.Multiline = true;
            statsstextbox.ScrollBars = ScrollBars.Vertical;
            statsstextbox.WordWrap = true;
            statsstextbox.ReadOnly = true;

            //Vordere den Stats-Wert zu dem ausgewählten ListView-Item bei der Logik-Schicht an und fülle die TextBox damit
            string maininfo = _iLogic.GetChampInfos(index, 2);
            statsstextbox.Text = maininfo;
        }

        private void story_btn_Click(object sender, EventArgs e)
        {
            //Cleare MainContentPanel, erzeuge und binde eine TextBox an MainContentPanel
            MainContentPanel.Controls.Clear();
            TextBox storytextbox = new TextBox();
            MainContentPanel.Controls.Add(storytextbox);
            storytextbox.Size = MainContentPanel.Size;
            storytextbox.Name = "Story";
            storytextbox.Multiline = true;
            storytextbox.ScrollBars = ScrollBars.Vertical;
            storytextbox.WordWrap = true;
            storytextbox.ReadOnly = true;

            //Vordere den Story-Wert zu dem ausgewählten ListView-Item bei der Logik-Schicht an und fülle die TextBox damit
            string maininfo = _iLogic.GetChampInfos(index, 3);
            storytextbox.Text = maininfo;
        }

        private void spells_btn_Click(object sender, EventArgs e)
        {
            //Cleare MainContentPanel, erzeuge Datagrid und binde es an ManContentPanel
            MainContentPanel.Controls.Clear();
            DataGridView abilitiesDataGrid = new DataGridView();
            MainContentPanel.Controls.Add(abilitiesDataGrid);
            abilitiesDataGrid.Size = MainContentPanel.Size;
            abilitiesDataGrid.Name = "Abilities";
            abilitiesDataGrid.ScrollBars = ScrollBars.Both;
            abilitiesDataGrid.Dock = DockStyle.Fill;
            abilitiesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            abilitiesDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            abilitiesDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            abilitiesDataGrid.ReadOnly = true;

            //Erzeuge Columns des DataGrids
            abilitiesDataGrid.Columns.Add(new DataGridViewImageColumn()
            {
                HeaderText = "",
                ReadOnly = true,
                FillWeight = 25,
                Width = 64,
            });
            abilitiesDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Abilityname",
                ReadOnly = true,
                FillWeight = 75,
                Width = 100
            });
            abilitiesDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Effect",
                ReadOnly = true,
                FillWeight = 125,
                Width = 300
            });
            abilitiesDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cooldown",
                ReadOnly = true,
                FillWeight = 175,
                Width = 150
            });
            abilitiesDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cost",
                ReadOnly = true,
                FillWeight = 225,
                Width = 150
            });

            //Vordere die Abilitys-Daten für das ausgewählten ListView-Item bei der Logik-Schicht an und fülle das DataGrid mit den Daten
            List<List<string>> abilityslist = _iLogic.GetAbilitiesData(index);
            for (int i = 0; i < abilityslist.Count; i++)
            {
                abilitiesDataGrid.Rows.Add(Image.FromFile(_iLogic.Imagdirectorypath() + abilityslist[i][4], true), abilityslist[i][0], abilityslist[i][1], abilityslist[i][2], abilityslist[i][3]);
            }
        }
    }
}
