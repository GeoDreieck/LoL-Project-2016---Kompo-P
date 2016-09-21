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
    public partial class Overview : Form, IForms
    {

        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;
        #endregion

        public Overview(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creeps_Click(object sender, EventArgs e)
        {
            Form cr = AFactoryIForms.CreateInstance("Creeps", _iLogic);
            cr.Show();
        }

        private void Masterie_Click(object sender, EventArgs e)
        {
            Form cr = AFactoryIForms.CreateInstance("Masterie", _iLogic);
            cr.Show();
        }

        private void Runes_Click(object sender, EventArgs e)
        {
            Form ru  = AFactoryIForms.CreateInstance("Runes", _iLogic);
            ru.Show();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            Form it = AFactoryIForms.CreateInstance("Items", _iLogic);
            it.Show();
        }

        private void Fields_Click(object sender, EventArgs e)
        {
            Form field = AFactoryIForms.CreateInstance("Fields", _iLogic);
            field.Show();
        }

        private void Tipps_Click(object sender, EventArgs e)
        {
            Form tipp = AFactoryIForms.CreateInstance("Form", _iLogic);
            tipp.Show();
        }

        private void SummonerSpells_Click(object sender, EventArgs e)
        {
            Form sm = AFactoryIForms.CreateInstance("Summoner_Spells", _iLogic);
            sm.Show();
        }

        private void Champions_Click(object sender, EventArgs e)
        {
            
            Form ch = AFactoryIForms.CreateInstance("Champions", _iLogic);
            ch.Show();
            
        }

        private void Overwiew_Load(object sender, EventArgs e)
        {

        }
    }
}
