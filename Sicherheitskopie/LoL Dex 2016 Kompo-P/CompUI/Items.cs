/*
 * Items.cs implementiert den ctor und die EventHandler und Fields von dem Items-Forms-Object.
 * Items wird beim Laden des Forms aufgerufen und Füllt die ListView und wählt das erste Item dieser aus.
 * lView_Items_SelectedIndexChanged wird aufgerufen, wenn sich SelectedIndices der ListView ändert. Sie sorgt dafür, dass das Icon in die PictureBox und die Stats-Infos in eine TextBox geladen werden.
 * Außerdem werden dynamisch alle Items oben in PictureBoxen angezeigt, die sich aus dem aktuell ausgewählten Item der ListView bauen lassen.
 * stats_btn_Click ist das Click-Event von stats_btn und erzeugt eine Textbox in die die Stats des ausgewählten Items der ListView geladen werden.
 * special_btn_Click ist das Click-Event von special_btn und erzeugt eine Textbox in die die speziellen Effekte des ausgewählten Items der ListView geladen werden.
 * build_btn_Click ist das Click-Event von build_btn und erzeugt eine PictureBox in der Buildtree des ausgewählten Items der ListView geladen wird.
 * parenticon_Click ist das Click-Event von den von lView_Items_SelectedIndexChanged erstellten PictureBoxen und wählt das Item aus der ListView aus, dass in der PictureBox zu sehen ist.
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
    public partial class Items : Form, IForms
    {
        #region fields
        // Assoziation zur Komponente CompLogic
        private ILogic _iLogic;

        // Erstellen einer index-Variablen um nicht immer SelectedIndex der Listview aufrufen zu müssen
        int index;
        #endregion

        public Items(ILogic iLogic)
        {
            InitializeComponent();

            //Logic-Abhängigkeit wird eingebunden
            _iLogic = iLogic;
        }

        private void Items_Load(object sender, EventArgs e)
        {
            //Variablen erstellen
            string[,] itemsnames = _iLogic.GetItemNames();
            ListViewItem iditemPair;

            //Listview füllen
            for (int i = 0; i < (itemsnames.Length / itemsnames.Rank); i++)
            {
                iditemPair = new ListViewItem(itemsnames[i, 0]);
                iditemPair.SubItems.Add(itemsnames[i, 1]);

                lView_Items.Items.AddRange(new ListViewItem[] { iditemPair });
            }

            //Erstes Item der Listview
            lView_Items.FindItemWithText("1").Selected = true;
            index = lView_Items.Items.IndexOf(lView_Items.SelectedItems[0]);
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox statsstextbox = new TextBox();
            MainContentPanel.Controls.Add(statsstextbox);
            statsstextbox.Size = MainContentPanel.Size;
            statsstextbox.Name = "Stats";
            statsstextbox.Multiline = true;
            statsstextbox.ScrollBars = ScrollBars.Vertical;
            statsstextbox.WordWrap = true;
            statsstextbox.ReadOnly = true;

            string maininfo = _iLogic.GetItemInfos(index, 2);

            statsstextbox.Text = maininfo;
        }

        private void special_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            TextBox specialstextbox = new TextBox();
            MainContentPanel.Controls.Add(specialstextbox);
            specialstextbox.Size = MainContentPanel.Size;
            specialstextbox.Name = "Special";
            specialstextbox.Multiline = true;
            specialstextbox.ScrollBars = ScrollBars.Vertical;
            specialstextbox.WordWrap = true;
            specialstextbox.ReadOnly = true;

            string maininfo = _iLogic.GetItemInfos(index, 3);

            specialstextbox.Text = maininfo;
        }

        private void build_btn_Click(object sender, EventArgs e)
        {
            MainContentPanel.Controls.Clear();
            PictureBox buildpathiconbox = new PictureBox();
            MainContentPanel.Controls.Add(buildpathiconbox);
            buildpathiconbox.Size = MainContentPanel.Size;
            buildpathiconbox.Name = "Build";

            buildpathiconbox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetItemInfos(index, 4), true);
            buildpathiconbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buildpathiconbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void lView_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            Wenn kein Element der ListView ausgewählt ist, tuhe nichts;
            Fängt ab, dass beim neuen Auswählen eines ListView-Items erst alle SelectedIndices auf
            null gesetzt werden und dann mindestens ein Element in SelectedIndices eingefügt wird und damit
            zwei SelectedIndexChanged-Events aufgerufen werden
            */
            if (lView_Items.SelectedIndices.Count <= 0)
                return;

            //Wenn SelectedIndices nicht leer ist, setze index auf den Wert des neu ausgewählten Items,
            //lade die Stats dafür über stats_btn.PerformClick(), lade das passende Icon in die erste Picturebox 
            //und die Icons der Items zu dem sich das ListViewItems baut
            if (lView_Items.SelectedIndices[0] >= 0)
            {
                index = lView_Items.SelectedIndices[0];
                stats_btn.PerformClick();
                ItemIconBox.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + _iLogic.GetItemInfos(index, 5), true);

                //Lade alle Icons der Items zu dem das ListViewItem sich bauen lässt in eine String-List
                List<List<string>> iconlist = _iLogic.GetIconsforParentitems(index+1);
                ParentItemPanel.Controls.Clear();
                int versetzung = 0;

                for (int i = 0; i < iconlist.Count; i++)
                {
                    //Erzeuge PictureBox, fülle sie mit einem Icon und binde sie an ParentItemPanel
                    //Binde außerdem einen EventHandler für das Click-Event an die neue PictureBox
                    PictureBox parentitem = new PictureBox();
                    parentitem.Size = new Size(60, 60);
                    parentitem.Tag = Convert.ToInt32(iconlist[i][0]) + 1;
                    parentitem.BackgroundImage = Image.FromFile(_iLogic.Imagdirectorypath() + iconlist[i][1], true);
                    parentitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    parentitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    ParentItemPanel.Controls.Add(parentitem);
                    parentitem.Location = new Point ( parentitem.Location.X + versetzung, parentitem.Location.Y );
                    versetzung = versetzung + parentitem.Width;
                    parentitem.Click += new EventHandler(parenticon_Click);
                }
            }
        }

        private void parenticon_Click(object sender, EventArgs e)
        {
            //Leere SelectedIndices der ListView, erstelle eine Kopie des Senderobjektes 
            //und wähle das zum Tag des Senderobjekts passende Item der ListView aus
            lView_Items.SelectedIndices.Clear();
            PictureBox clickedItem = (PictureBox)sender;
            lView_Items.FindItemWithText(clickedItem.Tag.ToString()).Selected = true;
        }
    }
}
