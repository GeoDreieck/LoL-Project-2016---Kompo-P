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
        int index;
        #endregion

        public Summoner_Spells(ILogic iLogic)
        {
            InitializeComponent();

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
            if (lView_Spells.SelectedIndices.Count <= 0)
                return;

            if (lView_Spells.SelectedIndices[0] >= 0)
            {
                index = lView_Spells.SelectedIndices[0];

                MainContentPanel.Controls.Clear();
                TextBox statsstextbox = new TextBox();
                MainContentPanel.Controls.Add(statsstextbox);
                statsstextbox.Size = MainContentPanel.Size;
                statsstextbox.Name = "Stats";
                statsstextbox.Multiline = true;
                statsstextbox.ScrollBars = ScrollBars.Vertical;
                statsstextbox.WordWrap = true;
                statsstextbox.ReadOnly = true;

                string maininfo = _iLogic.GetSummonerSpellsInfo(index, 2);

                statsstextbox.Text = maininfo;

                CooldownContentPanel.Controls.Clear();
                TextBox cooldownstextbox = new TextBox();
                CooldownContentPanel.Controls.Add(cooldownstextbox);
                cooldownstextbox.Size = CooldownContentPanel.Size;
                cooldownstextbox.Name = "Stats";
                cooldownstextbox.Multiline = true;
                cooldownstextbox.WordWrap = true;
                cooldownstextbox.ReadOnly = true;

                string cooldowninfo = "Cooldown: " + _iLogic.GetSummonerSpellsInfo(index, 3);

                cooldownstextbox.Text = cooldowninfo;

                SpellsIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetSummonerSpellsInfo(index, 4), true);
            }
        }
    }
}
