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
        #endregion

        public Runes(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void Runes_Load(object sender, EventArgs e)
        {

        }
    }
}
