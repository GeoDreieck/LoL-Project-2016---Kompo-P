namespace CompUI
{
    partial class Runes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunesIconBox = new System.Windows.Forms.PictureBox();
            this.rune_level_box = new System.Windows.Forms.ComboBox();
            this.rune_proberty_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lView_Runes = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Runenname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainContentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RunesIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RunesIconBox
            // 
            this.RunesIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RunesIconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RunesIconBox.Location = new System.Drawing.Point(31, 12);
            this.RunesIconBox.Name = "RunesIconBox";
            this.RunesIconBox.Size = new System.Drawing.Size(133, 133);
            this.RunesIconBox.TabIndex = 12;
            this.RunesIconBox.TabStop = false;
            // 
            // rune_level_box
            // 
            this.rune_level_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rune_level_box.FormattingEnabled = true;
            this.rune_level_box.Items.AddRange(new object[] {
            "Alle",
            "Stufe 1",
            "Stufe 2",
            "Stufe 3"});
            this.rune_level_box.Location = new System.Drawing.Point(354, 57);
            this.rune_level_box.Name = "rune_level_box";
            this.rune_level_box.Size = new System.Drawing.Size(121, 21);
            this.rune_level_box.TabIndex = 15;
            this.rune_level_box.Tag = "";
            this.rune_level_box.SelectedIndex = 0;
            this.rune_level_box.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // rune_proberty_box
            // 
            this.rune_proberty_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rune_proberty_box.FormattingEnabled = true;
            this.rune_proberty_box.Items.AddRange(new object[] {
            "Alle",
            "Essenzen",
            "Glyphen",
            "Marks",
            "Seals"});
            this.rune_proberty_box.Location = new System.Drawing.Point(510, 57);
            this.rune_proberty_box.Name = "rune_proberty_box";
            this.rune_proberty_box.Size = new System.Drawing.Size(121, 21);
            this.rune_proberty_box.TabIndex = 16;
            this.rune_proberty_box.SelectedIndex = 0;
            this.rune_proberty_box.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Runen - Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Runen - Art";
            // 
            // lView_Runes
            // 
            this.lView_Runes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Runenname});
            this.lView_Runes.LabelEdit = true;
            this.lView_Runes.Location = new System.Drawing.Point(31, 170);
            this.lView_Runes.Name = "lView_Runes";
            this.lView_Runes.Size = new System.Drawing.Size(161, 336);
            this.lView_Runes.TabIndex = 19;
            this.lView_Runes.UseCompatibleStateImageBehavior = false;
            this.lView_Runes.View = System.Windows.Forms.View.Details;
            this.lView_Runes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Runenname
            // 
            this.Runenname.Text = "Runenname";
            this.Runenname.Width = 150;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Location = new System.Drawing.Point(253, 165);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(463, 336);
            this.MainContentPanel.TabIndex = 20;
            // 
            // Runes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 525);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.lView_Runes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rune_proberty_box);
            this.Controls.Add(this.rune_level_box);
            this.Controls.Add(this.RunesIconBox);
            this.Name = "Runes";
            this.Text = "Runes";
            this.Load += new System.EventHandler(this.Runes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RunesIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RunesIconBox;
        private System.Windows.Forms.ComboBox rune_level_box;
        private System.Windows.Forms.ComboBox rune_proberty_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lView_Runes;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Runenname;
        private System.Windows.Forms.Panel MainContentPanel;
    }
}