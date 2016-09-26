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
        #endregion

        public Summoner_Spells(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void Summoner_Spells_load(object sender, EventArgs e)
        {

        }

        private void Summoner_Spells_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
