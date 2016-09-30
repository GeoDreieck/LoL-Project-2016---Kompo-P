/*
 * Creeps.cs implementiert den ctor und die EventHandler und Fields von dem Creepy-Forms-Object.
 * Creeps wird beim Laden des Forms aufgerufen und Füllt die ListView und wählt das erste Item dieser aus.
 * lView_creeps_SelectedIndexChanged wird aufgerufen, wenn sich SelectedIndices der ListView ändert. Sie sorgt dafür, dass das Icon in die PictureBox und die Stats-Infos in eine TextBox geladen werden.
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
    internal partial class Creeps : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        // Erstellen einer index-Variablen um nicht immer SelectedIndex der Listview aufrufen zu müssen
        int index;
        #endregion

        public Creeps(ILogic iLogic)
        {
            InitializeComponent();

            // Erstellen einer index-Variablen um nicht immer SelectedIndex der Listview aufrufen zu müssen
            _iLogic = iLogic;
        }

        private void Creeps_Load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] creepsnames = _iLogic.GetCreepsNames();
            ListViewItem idcreepsname;

            //Listview füllen
            for (int i = 0; i < (creepsnames.Length / creepsnames.Rank); i++)
            {
                idcreepsname = new ListViewItem(creepsnames[i, 0]);
                idcreepsname.SubItems.Add(creepsnames[i, 1]);

                lView_creeps.Items.AddRange(new ListViewItem[] { idcreepsname });
            }

            //Erstes Item der Listview
            lView_creeps.FindItemWithText("1").Selected = true;
            index = lView_creeps.Items.IndexOf(lView_creeps.SelectedItems[0]);
        }

        private void lView_creeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Wenn kein Element der ListView ausgewählt ist, tuhe nichts;
            Fängt ab, dass beim neuen Auswählen eines ListView-Items erst alle SelectedIndices auf
            null gesetzt werden und dann mindestens ein Element in SelectedIndices eingefügt wird und damit
            zwei SelectedIndexChanged-Events aufgerufen werden
            */
            if (lView_creeps.SelectedIndices.Count <= 0)
                return;

            //Wenn SelectedIndices nicht leer ist, setze index auf den Wert des neu ausgewählten Items,
            //lade die Infos dafür für das Item der ListView und lade das passende Icon in die Picturebox
            if (lView_creeps.SelectedIndices[0] >= 0)
            {
                //Weise index den neuen Wert zu
                index = lView_creeps.SelectedIndices[0];

                //Cleare MainContentPanel, erzeuge und binde eine Textbox ans MainContentPanel
                MainContentPanel.Controls.Clear();
                TextBox creepsstatbox = new TextBox();
                MainContentPanel.Controls.Add(creepsstatbox);
                creepsstatbox.Size = MainContentPanel.Size;
                creepsstatbox.Name = "Stats";
                creepsstatbox.Multiline = true;
                creepsstatbox.ScrollBars = ScrollBars.Vertical;
                creepsstatbox.WordWrap = true;
                creepsstatbox.ReadOnly = true;

                //Vordere die Infos zu dem ausgewählten ListView-Item bei der Logic-Schicht an und fülle die TextBox damit
                string maininfo = "Spawntime: " + _iLogic.GetCreepInfos(index, 2) + "\n Buff: " + _iLogic.GetCreepInfos(index, 3) + "\n Gold: " + _iLogic.GetCreepInfos(index, 4);
                creepsstatbox.Text = maininfo;

                //Lade das Icon zu dem ListViewItem aus dem DataSet und setze das BackGroundImage der PictureBox gleich dem Icon
                CreepsIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetCreepInfos(index, 5), true);
            }
        }

      }
}
