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
    public partial class Champions : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;
        #endregion

        public Champions(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void Champions_Load(object sender, EventArgs e)
        {
            string[,] champnames = _iLogic.GetChampNames();
            ListViewItem idchampPair;

            for(int i = 0; i < (champnames.Length/champnames.Rank); i++)
            {
                idchampPair = new ListViewItem(champnames[i, 0]);
                idchampPair.SubItems.Add(champnames[i, 1]);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChampIDAndNameslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
