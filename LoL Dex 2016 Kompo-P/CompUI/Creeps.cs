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
    public partial class Creeps : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        int index;
        #endregion

        public Creeps(ILogic iLogic)
        {
            InitializeComponent();

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
            if (lView_creeps.SelectedIndices.Count <= 0)
                return;

            if (lView_creeps.SelectedIndices[0] >= 0)
            {
                index = lView_creeps.SelectedIndices[0];

                MainContentPanel.Controls.Clear();
                TextBox creepsstatbox = new TextBox();
                MainContentPanel.Controls.Add(creepsstatbox);
                creepsstatbox.Size = MainContentPanel.Size;
                creepsstatbox.Name = "Stats";
                creepsstatbox.Multiline = true;
                creepsstatbox.ScrollBars = ScrollBars.Vertical;
                creepsstatbox.WordWrap = true;
                creepsstatbox.ReadOnly = true;

                string maininfo = "Spawntime: " + _iLogic.GetCreepInfos(index, 2) + "\n Buff: " + _iLogic.GetCreepInfos(index, 3) + "\n Gold: " + _iLogic.GetCreepInfos(index, 4);

                creepsstatbox.Text = maininfo;

                CreepsIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetCreepInfos(index, 5), true);
            }
        }
      }
}
