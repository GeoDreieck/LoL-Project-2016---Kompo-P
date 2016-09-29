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
    public partial class Runes : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        int index;
        #endregion

        public Runes(ILogic iLogic)
        {
            InitializeComponent();

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lView_Runes.SelectedIndices.Count <= 0)
                return;

            if (lView_Runes.SelectedIndices[0] >= 0)
            {
                index = lView_Runes.SelectedIndices[0];

                MainContentPanel.Controls.Clear();
                TextBox statsstextbox = new TextBox();
                MainContentPanel.Controls.Add(statsstextbox);
                statsstextbox.Size = MainContentPanel.Size;
                statsstextbox.Name = "Stats";
                statsstextbox.Multiline = true;
                statsstextbox.ScrollBars = ScrollBars.Vertical;
                statsstextbox.WordWrap = true;

                string maininfo =  _iLogic.GetRunesInfos(index, 2) + " " + _iLogic.GetRunesInfos(index, 3);

                statsstextbox.Text = maininfo;


                RunesIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetRunesInfos(index, 4), true);
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            lView_Runes.Items.Clear();

            //Variablen erstellen
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
