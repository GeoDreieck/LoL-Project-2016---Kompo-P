/*
 * Summoner Spells.cs implementiert den ctor und die EventHandler und Fields von dem Summoner Spells-Forms-Object.
 * Summoner_Spells_Load wird beim Laden des Forms aufgerufen und Füllt die ListView und wählt das erste Item dieser aus.
 * lView_Summoner_Spells_SelectedIndexChanged wird aufgerufen, wenn sich SelectedIndices der ListView ändert. Sie sorgt dafür, dass das Icon in die PictureBox und die Stats-Infos in eine TextBox im MainContentPanel und die Cooldown-Infos im CooldownContentPanel geladen werden.
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
    public partial class Summoner_Spells : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        //Lade das Icon zu dem ListViewItem aus dem DataSet und setze das BackGroundImage der PictureBox gleich dem Icon
        int index;
        #endregion

        public Summoner_Spells(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        private void Summoner_Spells_load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] summonerspellsnames = _iLogic.GetSummonerSpellsNames();
            ListViewItem idspellsPair;

            //Listview füllen
            for (int i = 0; i < (summonerspellsnames.Length / summonerspellsnames.Rank); i++)
            {
                idspellsPair = new ListViewItem(summonerspellsnames[i, 0]);
                idspellsPair.SubItems.Add(summonerspellsnames[i, 1]);

                lView_Spells.Items.AddRange(new ListViewItem[] { idspellsPair });
            }

            //Erstes Item der Listview
            lView_Spells.FindItemWithText("1").Selected = true;
            index = lView_Spells.Items.IndexOf(lView_Spells.SelectedItems[0]);
        }

        private void lView_Spells_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Wenn kein Element der ListView ausgewählt ist, tuhe nichts;
            Fängt ab, dass beim neuen Auswählen eines ListView-Items erst alle SelectedIndices auf
            null gesetzt werden und dann mindestens ein Element in SelectedIndices eingefügt wird und damit
            zwei SelectedIndexChanged-Events aufgerufen werden
            */
            if (lView_Spells.SelectedIndices.Count <= 0)
                return;

            //Wenn SelectedIndices nicht leer ist, setze index auf den Wert des neu ausgewählten Items,
            //fordere die Infos zu dem Item aus der Logic-Schicht an und lade das passende Icon in die Picturebox
            if (lView_Spells.SelectedIndices[0] >= 0)
            {
                //Weise index den neuen Wert zu
                index = lView_Spells.SelectedIndices[0];

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
                string maininfo = _iLogic.GetSummonerSpellsInfo(index, 2);
                statsstextbox.Text = maininfo;

                //Cleare MainContentPanel, erzeuge und binde eine Textbox ans CooldownContentPanel
                CooldownContentPanel.Controls.Clear();
                TextBox cooldownstextbox = new TextBox();
                CooldownContentPanel.Controls.Add(cooldownstextbox);
                cooldownstextbox.Size = CooldownContentPanel.Size;
                cooldownstextbox.Name = "Stats";
                cooldownstextbox.Multiline = true;
                cooldownstextbox.WordWrap = true;
                cooldownstextbox.ReadOnly = true;

                //Vordere die Infos zu dem ausgewählten ListView-Item bei der Logic-Schicht an und fülle die TextBox damit
                string cooldowninfo = "Cooldown: " + _iLogic.GetSummonerSpellsInfo(index, 3);
                cooldownstextbox.Text = cooldowninfo;

                //Lade das Icon zu dem ListViewItem aus dem DataSet und setze das BackGroundImage der PictureBox gleich dem Icon
                SpellsIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetSummonerSpellsInfo(index, 4), true);
            }
        }
    }
}
