﻿using System;
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
    internal partial class Overview : Form, IForms
    {

        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;
        #endregion

        public Overview(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        //Ein Klick-Event für jeden Button. Jeder Button ruft beim Klick
        //AFactoryIForms mit dem passenden String auf, speichert den Rückgabewert in cr und zeige cr an
        private void Creeps_Click(object sender, EventArgs e)
        {
            IForms cr = AFactoryIForms.CreateInstance("Creeps", _iLogic);
            cr.Show();
        }

        private void Masterie_Click(object sender, EventArgs e)
        {
            IForms cr = AFactoryIForms.CreateInstance("Masteries", _iLogic);
            cr.Show();
        }

        private void Runes_Click(object sender, EventArgs e)
        {
            IForms ru  = AFactoryIForms.CreateInstance("Runes", _iLogic);
            ru.Show();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            IForms it = AFactoryIForms.CreateInstance("Items", _iLogic);
            it.Show();
        }

        private void Fields_Click(object sender, EventArgs e)
        {
           IForms field = AFactoryIForms.CreateInstance("Fields", _iLogic);
            field.Show();
        }

        private void Tipps_Click(object sender, EventArgs e)
        {
            IForms tipp = AFactoryIForms.CreateInstance("Tipps", _iLogic);
            tipp.Show();
        }

        private void SummonerSpells_Click(object sender, EventArgs e)
        {
            IForms sm = AFactoryIForms.CreateInstance("Summoner_Spells", _iLogic);
            sm.Show();
        }

        private void Champions_Click(object sender, EventArgs e)
        {
            
            IForms ch = AFactoryIForms.CreateInstance("Champions", _iLogic);
            ch.Show();
            
        }

        private void Overwiew_Load(object sender, EventArgs e)
        {

        }
    }
}
