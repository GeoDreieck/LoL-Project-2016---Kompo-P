﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompUI
{
    public partial class Overwiew : Form
    {
        public Overwiew()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creeps_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creeps cr = new Creeps();
            cr.Show();
        }

        private void Masterie_Click(object sender, EventArgs e)
        {

        }

        private void Runes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rumes  = new Champions();
            ch.Show();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items it = new Items();
            Items.Show();
        }

        private void Fields_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fields field = new Fields();
            field.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Champions();
            search.Show();
        }

        private void Tipps_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tipps tipp = new Champions();
            tipp.Show();
        }

        private void SummonerSpells_Click(object sender, EventArgs e)
        {
            this.Hide();
            Summoner_Spells sm = new Champions();
            sm.Show();
        }

        private void Champions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Champions ch = new Champions();
            ch.Show();
        }

        private void Overwiew_Load(object sender, EventArgs e)
        {

        }
    }
}
