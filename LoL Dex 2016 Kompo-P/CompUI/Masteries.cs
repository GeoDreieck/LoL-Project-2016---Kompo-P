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
    public partial class Masteries : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;
        #endregion

        public Masteries(ILogic iLogic)
        {
            InitializeComponent();

            _iLogic = iLogic;
        }

        private void Masteries_Load(object sender, EventArgs e)
        {
            Tree1.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(1), true);
            Tree2.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(2), true);
            Tree3.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(3), true);
        }

        private void FuryPanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(0));
        }

        private void Sorcerypanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(1));
        }

        private void ExposeWeaknesspanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(5));
        }

        private void Feastpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(4));
        }

        private void DoubleEdgedSwordpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(3));
        }

        private void Vampirismpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(6));
        }

        private void NaturalTalentpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(7));
        }

        private void Oppressorpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(9));
        }

        private void BountyHunterpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(8));
        }

        private void BatteringBlowspanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(10));
        }

        private void PiercingThoughtspanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(11));
        }

        private void DeathfireTouchpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(14));
        }

        private void FervorofBattlepanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(13));
        }

        private void WarlordsBloodlustpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(12));
        }

        private void Wandererpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(15));
        }

        private void Savagerypanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(16));
        }

        private void Assassinpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(19));
        }

        private void SecretStashpanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(18));
        }

        private void RunicAffinitypanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(17));
        }

        private void Mercilesspanel_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip = new System.Windows.Forms.ToolTip();
            ToolTip.SetToolTip(this.FuryPanel, _iLogic.GetMasterieInfo(20));
        }
    }
}
