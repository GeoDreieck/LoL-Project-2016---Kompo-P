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
    public partial class Items : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        int index;
        #endregion

        public Items(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] itemsnames = _iLogic.GetItemNames();
            ListViewItem iditemPair;

            //Listview füllen
            for (int i = 0; i < (itemsnames.Length / itemsnames.Rank); i++)
            {
                iditemPair = new ListViewItem(itemsnames[i, 0]);
                iditemPair.SubItems.Add(itemsnames[i, 1]);

                lView_Items.Items.AddRange(new ListViewItem[] { iditemPair });
            }

            //Erstes Item der Listview
            lView_Items.FindItemWithText("1").Selected = true;
            index = lView_Items.Items.IndexOf(lView_Items.SelectedItems[0]);
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox statsstextbox = new TextBox();
            MainContentPanel.Controls.Add(statsstextbox);
            statsstextbox.Size = MainContentPanel.Size;
            statsstextbox.Name = "Stats";
            statsstextbox.Multiline = true;
            statsstextbox.ScrollBars = ScrollBars.Vertical;
            statsstextbox.WordWrap = true;
            statsstextbox.ReadOnly = true;

            string maininfo = _iLogic.GetItemInfos(index, 2);

            statsstextbox.Text = maininfo;
        }

        private void special_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox specialstextbox = new TextBox();
            MainContentPanel.Controls.Add(specialstextbox);
            specialstextbox.Size = MainContentPanel.Size;
            specialstextbox.Name = "Special";
            specialstextbox.Multiline = true;
            specialstextbox.ScrollBars = ScrollBars.Vertical;
            specialstextbox.WordWrap = true;
            specialstextbox.ReadOnly = true;

            string maininfo = _iLogic.GetItemInfos(index, 3);

            specialstextbox.Text = maininfo;
        }

        private void build_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            PictureBox buildpathiconbox = new PictureBox();
            MainContentPanel.Controls.Add(buildpathiconbox);
            buildpathiconbox.Size = MainContentPanel.Size;
            buildpathiconbox.Name = "Build";

            buildpathiconbox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetItemInfos(index, 4), true);
            buildpathiconbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buildpathiconbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void lView_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lView_Items.SelectedIndices.Count <= 0)
                return;

            if (lView_Items.SelectedIndices[0] >= 0)
            {
                index = lView_Items.SelectedIndices[0];
                stats_btn.PerformClick();
                ItemIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetItemInfos(index, 5), true);

                List<string> iconlist = _iLogic.GetIconsforParentitems(index+1);
                ParentItemPanel.Controls.Clear();

                for (int i = 0; i < iconlist.Count; i++)
                {
                    PictureBox parentitem = new PictureBox();
                    parentitem.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + iconlist[i], true);
                    parentitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    parentitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    ParentItemPanel.Controls.Add(parentitem);
                }
            }
        }
    }
}
