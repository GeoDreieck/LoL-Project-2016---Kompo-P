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
            ChampIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetChampInfos(index, 6), true);
        }

        private void ChampIconBox_Click(object sender, EventArgs e)
        {

        }

        private void lView_Champnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            stats_btn.PerformClick();

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            string maininfo = _iLogic.GetChampInfos(index, 1);

            lView_Content.Items.Clear();
            lView_Content.Items.Add(maininfo);
        }
    }
}
