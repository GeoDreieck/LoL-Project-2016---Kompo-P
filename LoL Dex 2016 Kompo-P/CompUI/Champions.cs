﻿using System;
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

        int index;
        #endregion

        public Champions(ILogic iLogic)
        {
            InitializeComponent();

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

            //Öffne Stats des ersten Items
            stats_btn.PerformClick();
            ChampIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetChampInfos(index, 7), true);
        }

        private void ChampIconBox_Click(object sender, EventArgs e)
        {

        }

        private void lView_Champnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            stats_btn.PerformClick();

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

            string maininfo = _iLogic.GetChampInfos(index, 2);

            statsstextbox.Text = maininfo;
        }

        private void tipps_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox tippstextbox = new TextBox();
            MainContentPanel.Controls.Add(tippstextbox);
            tippstextbox.Size = MainContentPanel.Size;
            tippstextbox.Name = "Stats";
            tippstextbox.Multiline = true;
            tippstextbox.ScrollBars = ScrollBars.Vertical;
            tippstextbox.WordWrap = true;

            string maininfo = _iLogic.GetChampInfos(index, 3);

            tippstextbox.Text = maininfo;
        }

        private void story_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox storytextbox = new TextBox();
            MainContentPanel.Controls.Add(storytextbox);
            storytextbox.Size = MainContentPanel.Size;
            storytextbox.Name = "Stats";
            storytextbox.Multiline = true;
            storytextbox.ScrollBars = ScrollBars.Vertical;
            storytextbox.WordWrap = true;

            string maininfo = _iLogic.GetChampInfos(index, 4);

            storytextbox.Text = maininfo;
        }

        private void spells_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
