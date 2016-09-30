/*
 * Runes.cs implementiert den ctor und die EventHandler und Fields von dem Runes-Forms-Object.
 * Runes wird beim Laden des Forms aufgerufen und Füllt die ListView und wählt das erste Item dieser aus.
 * lView_Runes_SelectedIndexChanged wird aufgerufen, wenn sich SelectedIndices der ListView ändert. Sie sorgt dafür, dass das Icon in die PictureBox und die Stats-Infos in eine TextBox geladen werden.
 * FilterChanged ist der EventHandler für beide die SelectedIndexChanged-Events beider ComboBoxen und benutzt die ausgewählten Indexe beider ComboBoxen als Filter um eine begrenzte Ausgabe aller Runes in die ListView zu laden.
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

using CompLogic;

namespace CompUI
{
    internal partial class Runes : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        // Erstellen einer index-Variablen um nicht immer SelectedIndex der Listview aufrufen zu müssen
        int index;
        #endregion

        public Runes(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        private void Runes_Load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] runesnames = _iLogic.GetAllRunesNames();
            ListViewItem idrunePair;

            //Listview füllen
            for (int i = 0; i < (runesnames.Length / runesnames.Rank); i++)
            {
                idrunePair = new ListViewItem(runesnames[i, 0]);
                idrunePair.SubItems.Add(runesnames[i, 1]);

                lView_Runes.Items.AddRange(new ListViewItem[] { idrunePair });
            }

            //Erstes Item der Listview
            lView_Runes.FindItemWithText("1").Selected = true;
            index = lView_Runes.Items.IndexOf(lView_Runes.SelectedItems[0]);
        }

        private void lView_Runes_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Wenn kein Element der ListView ausgewählt ist, tuhe nichts;
            Fängt ab, dass beim neuen Auswählen eines ListView-Items erst alle SelectedIndices auf
            null gesetzt werden und dann mindestens ein Element in SelectedIndices eingefügt wird und damit
            zwei SelectedIndexChanged-Events aufgerufen werden
            */
            if (lView_Runes.SelectedIndices.Count <= 0)
                return;

            //Wenn SelectedIndices nicht leer ist, setze index auf den Wert des neu ausgewählten Items,
            //fordere die Infos von der Logic-Schicht and und gebe sie aus und lade das passende Icon in die Picturebox
            if (lView_Runes.SelectedIndices[0] >= 0)
            {
                //Weise index den neuen Wert zu
                index = lView_Runes.SelectedIndices[0];

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

                //Vordere die Infos zu dem ausgewählten ListView-Item bei der Logic-Schicht an und fülle die TextBox damit
                string maininfo =  _iLogic.GetRunesInfos(index, 2) + " " + _iLogic.GetRunesInfos(index, 3);
                statsstextbox.Text = maininfo;

                //Lade das Icon zu dem ListViewItem aus dem DataSet und setze das BackGroundImage der PictureBox gleich dem Icon
                RunesIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetRunesInfos(index, 4), true);
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            //ListView leeren
            lView_Runes.Items.Clear();

            //Variablen erstellen und für runesnames die Informationen für die neue Litview aus der Logic-Schicht anfordern.
            //Dem Funktionsaufruf GetSelectedRunesNames werden als Parameter die ausgewählten Items der beiden ComboBoxen übergeben, die als Filter dienen
            string[,] runesnames = _iLogic.GetSelectedRunesNames(rune_proberty_box.SelectedItem.ToString(), rune_level_box.SelectedItem.ToString());
            ListViewItem idrunePair;

            //Listview füllen
            for (int i = 0; i < (runesnames.Length / runesnames.Rank); i++)
            {
                idrunePair = new ListViewItem(runesnames[i, 0]);
                idrunePair.SubItems.Add(runesnames[i, 1]);

                lView_Runes.Items.AddRange(new ListViewItem[] { idrunePair });
            }
        }
    }
}
