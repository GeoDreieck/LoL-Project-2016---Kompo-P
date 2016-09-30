/*
 * Masteries.cs implementiert den ctor und die EventHandler und Fields von dem Masteries-Forms-Object.
 * Champions_Load wird beim Laden des Forms aufgerufen und läd die BackgroundImages der drei PictureBoxen, bindet den EventHandler an timer.Tick und startet den Timer.
 * Timer_Tick ist der EventHandler von timer.Tick und überprüft ob die Maus sich gerade in einem Panel befindet und wenn sie das tut, werden die Informationen die zu dem Panel gehören in Masterieinfo geladen.
 */

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
    internal partial class Masteries : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        private Timer timer = new Timer();
        #endregion

        public Masteries(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        private void Masteries_Load(object sender, EventArgs e)
        {
            //BackgroundImages der drei PictureBoxen von der Logic-Schicht anfordern
            Tree1.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(1), true);
            Tree2.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(2), true);
            Tree3.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetTree(3), true);

            //Für den Timer einen Eventhandler zum Tick-Event hinzufügen und diesen starten
            timer.Tick += timer_Tick;
            timer.Start();

            //Masterieinfo auf ReadOnly stellen
            Masterieinfo.ReadOnly = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Variablen erstellen
            Rectangle r;
            int i = 0;

            /*
             Lade immer über PANELNAME.RectangleToScreen(PANELNAME.ClientRectangle)
             eine Kopie vom Areal eines Panels in ein Rechteck und überprüfe ob die
             Maus in diesem Gebiet ist. Wenn nicht, überprüfe das nächste Panel und zähle i um 1 hoch;
             Wenn die Maus in dem Areal eines Panels sich befinden, fordere die passenden Informationen
             aus der Logic-Schicht an und gebe sie in Masterieinfos aus.              
             */
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
    }
}
