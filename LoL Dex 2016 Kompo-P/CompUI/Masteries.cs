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

        private Timer timer = new Timer();
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

        private void timer_Tick(object sender, EventArgs e)
        {
            Rectangle r;
            int i = 0;
            try
            {
                r = FuryPanel.RectangleToScreen(FuryPanel.ClientRectangle);
            
            

            if (r.Contains(MousePosition))
            {
                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
            }
            else
            {
                i++;
                r = Sorcerypanel.RectangleToScreen(Sorcerypanel.ClientRectangle);

                if (r.Contains(MousePosition))
                {
                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                }
                else
                {
                    i++;
                    r = DoubleEdgedSwordpanel.RectangleToScreen(DoubleEdgedSwordpanel.ClientRectangle);

                    if (r.Contains(MousePosition))
                    {
                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(4, 2);
                    }
                    else
                    {
                        i++;
                        r = Feastpanel.RectangleToScreen(Feastpanel.ClientRectangle);

                        if (r.Contains(MousePosition))
                        {
                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(3, 2);
                        }
                        else
                        {
                            i++;
                            r = ExposeWeaknesspanel.RectangleToScreen(ExposeWeaknesspanel.ClientRectangle);

                            if (r.Contains(MousePosition))
                            {
                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                            }
                            else
                            {
                                i++;
                                r = Vampirismpanel.RectangleToScreen(Vampirismpanel.ClientRectangle);

                                if (r.Contains(MousePosition))
                                {
                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                }
                                else
                                {
                                    i++;
                                    r = NaturalTalentpanel.RectangleToScreen(NaturalTalentpanel.ClientRectangle);

                                    if (r.Contains(MousePosition))
                                    {
                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                    }
                                    else
                                    {
                                        i++;
                                        r = BountyHunterpanel.RectangleToScreen(BountyHunterpanel.ClientRectangle);

                                        if (r.Contains(MousePosition))
                                        {
                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                        }
                                        else
                                        {
                                            i++;
                                            r = Oppressorpanel.RectangleToScreen(Oppressorpanel.ClientRectangle);

                                            if (r.Contains(MousePosition))
                                            {
                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                            }
                                            else
                                            {
                                                i++;
                                                r = BatteringBlowspanel.RectangleToScreen(BatteringBlowspanel.ClientRectangle);

                                                if (r.Contains(MousePosition))
                                                {
                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                }
                                                else
                                                {
                                                    i++;
                                                    r = PiercingThoughtspanel.RectangleToScreen(PiercingThoughtspanel.ClientRectangle);

                                                    if (r.Contains(MousePosition))
                                                    {
                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                    }
                                                    else
                                                    {
                                                        i++;
                                                        r = WarlordsBloodlustpanel.RectangleToScreen(WarlordsBloodlustpanel.ClientRectangle);

                                                        if (r.Contains(MousePosition))
                                                        {
                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                        }
                                                        else
                                                        {
                                                            i++;
                                                            r = FervorofBattlepanel.RectangleToScreen(FervorofBattlepanel.ClientRectangle);

                                                            if (r.Contains(MousePosition))
                                                            {
                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                            }
                                                            else
                                                            {
                                                                i++;
                                                                r = DeathfireTouchpanel.RectangleToScreen(DeathfireTouchpanel.ClientRectangle);

                                                                if (r.Contains(MousePosition))
                                                                {
                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                }
                                                                else
                                                                {
                                                                    i++;
                                                                    r = Wandererpanel.RectangleToScreen(Wandererpanel.ClientRectangle);

                                                                    if (r.Contains(MousePosition))
                                                                    {
                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                    }
                                                                    else
                                                                    {
                                                                        i++;
                                                                        r = Savagerypanel.RectangleToScreen(Savagerypanel.ClientRectangle);

                                                                        if (r.Contains(MousePosition))
                                                                        {
                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                        }
                                                                        else
                                                                        {
                                                                            i++;
                                                                            r = RunicAffinitypanel.RectangleToScreen(RunicAffinitypanel.ClientRectangle);

                                                                            if (r.Contains(MousePosition))
                                                                            {
                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                            }
                                                                            else
                                                                            {
                                                                                i++;
                                                                                r = SecretStashpanel.RectangleToScreen(SecretStashpanel.ClientRectangle);

                                                                                if (r.Contains(MousePosition))
                                                                                {
                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                }
                                                                                else
                                                                                {
                                                                                    i++;
                                                                                    r = Assassinpanel.RectangleToScreen(Assassinpanel.ClientRectangle);

                                                                                    if (r.Contains(MousePosition))
                                                                                    {
                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        i++;
                                                                                        r = Mercilesspanel.RectangleToScreen(Mercilesspanel.ClientRectangle);

                                                                                        if (r.Contains(MousePosition))
                                                                                        {
                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            i++;
                                                                                            r = Meditationpanel.RectangleToScreen(Meditationpanel.ClientRectangle);

                                                                                            if (r.Contains(MousePosition))
                                                                                            {
                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                i++;
                                                                                                r = Banditpanel.RectangleToScreen(Banditpanel.ClientRectangle);

                                                                                                if (r.Contains(MousePosition))
                                                                                                {
                                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    i++;
                                                                                                    r = DangerousGamepanel.RectangleToScreen(DangerousGamepanel.ClientRectangle);

                                                                                                    if (r.Contains(MousePosition))
                                                                                                    {
                                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        i++;
                                                                                                        r = Precisionpanel.RectangleToScreen(Precisionpanel.ClientRectangle);

                                                                                                        if (r.Contains(MousePosition))
                                                                                                        {
                                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            i++;
                                                                                                            r = Intelligencepanel.RectangleToScreen(Intelligencepanel.ClientRectangle);

                                                                                                            if (r.Contains(MousePosition))
                                                                                                            {
                                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                i++;
                                                                                                                r = Stormraiderssurgepanel.RectangleToScreen(Stormraiderssurgepanel.ClientRectangle);

                                                                                                                if (r.Contains(MousePosition))
                                                                                                                {
                                                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    i++;
                                                                                                                    r = ThunderlordsDecreepanel.RectangleToScreen(ThunderlordsDecreepanel.ClientRectangle);

                                                                                                                    if (r.Contains(MousePosition))
                                                                                                                    {
                                                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        i++;
                                                                                                                        r = WindspeakersBlessingpanel.RectangleToScreen(WindspeakersBlessingpanel.ClientRectangle);

                                                                                                                        if (r.Contains(MousePosition))
                                                                                                                        {
                                                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            i++;
                                                                                                                            r = Recoverypanel.RectangleToScreen(Recoverypanel.ClientRectangle);

                                                                                                                            if (r.Contains(MousePosition))
                                                                                                                            {
                                                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                i++;
                                                                                                                                r = Unyieldingpanel.RectangleToScreen(Unyieldingpanel.ClientRectangle);

                                                                                                                                if (r.Contains(MousePosition))
                                                                                                                                {
                                                                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    i++;
                                                                                                                                    r = Explorerpanel.RectangleToScreen(Explorerpanel.ClientRectangle);

                                                                                                                                    if (r.Contains(MousePosition))
                                                                                                                                    {
                                                                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        i++;
                                                                                                                                        r = ToughSkinpanel.RectangleToScreen(ToughSkinpanel.ClientRectangle);

                                                                                                                                        if (r.Contains(MousePosition))
                                                                                                                                        {
                                                                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            i++;
                                                                                                                                            r = RunicArmorpanel.RectangleToScreen(RunicArmorpanel.ClientRectangle);

                                                                                                                                            if (r.Contains(MousePosition))
                                                                                                                                            {
                                                                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                i++;
                                                                                                                                                r = VeteransScarspanel.RectangleToScreen(VeteransScarspanel.ClientRectangle);

                                                                                                                                                if (r.Contains(MousePosition))
                                                                                                                                                {
                                                                                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    i++;
                                                                                                                                                    r = Insightpanel.RectangleToScreen(Insightpanel.ClientRectangle);

                                                                                                                                                    if (r.Contains(MousePosition))
                                                                                                                                                    {
                                                                                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        i++;
                                                                                                                                                        r = Perseverancepanel.RectangleToScreen(Perseverancepanel.ClientRectangle);

                                                                                                                                                        if (r.Contains(MousePosition))
                                                                                                                                                        {
                                                                                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            i++;
                                                                                                                                                            r = Swiftnesspanel.RectangleToScreen(Swiftnesspanel.ClientRectangle);

                                                                                                                                                            if (r.Contains(MousePosition))
                                                                                                                                                            {
                                                                                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                i++;
                                                                                                                                                                r = LegendaryGuardianpanel.RectangleToScreen(LegendaryGuardianpanel.ClientRectangle);

                                                                                                                                                                if (r.Contains(MousePosition))
                                                                                                                                                                {
                                                                                                                                                                    Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    i++;
                                                                                                                                                                    r = GraspoftheUndyingpanel.RectangleToScreen(GraspoftheUndyingpanel.ClientRectangle);

                                                                                                                                                                    if (r.Contains(MousePosition))
                                                                                                                                                                    {
                                                                                                                                                                        Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        i++;
                                                                                                                                                                        r = StrengthoftheAgespanel.RectangleToScreen(StrengthoftheAgespanel.ClientRectangle);

                                                                                                                                                                        if (r.Contains(MousePosition))
                                                                                                                                                                        {
                                                                                                                                                                            Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            i++;
                                                                                                                                                                            r = BondofStonepanel.RectangleToScreen(BondofStonepanel.ClientRectangle);

                                                                                                                                                                            if (r.Contains(MousePosition))
                                                                                                                                                                            {
                                                                                                                                                                                Masterieinfo.Text = _iLogic.GetMasterieInfo(i, 1) + ": " + _iLogic.GetMasterieInfo(i, 2);
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {

                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }

                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            }
            catch
            {
                timer.Stop();
            }
        }

        private void FuryPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
