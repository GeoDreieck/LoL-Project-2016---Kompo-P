namespace CompUI
{
    partial class Summoner_Spells
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
            this.SpellsIconBox = new System.Windows.Forms.PictureBox();
            this.lView_Spells = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Summoner_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.CooldownContentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SpellsIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpellsIconBox
            // 
            this.SpellsIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SpellsIconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpellsIconBox.Location = new System.Drawing.Point(68, 33);
            this.SpellsIconBox.Name = "SpellsIconBox";
            this.SpellsIconBox.Size = new System.Drawing.Size(170, 115);
            this.SpellsIconBox.TabIndex = 19;
            this.SpellsIconBox.TabStop = false;
            // 
            // lView_Spells
            // 
            this.lView_Spells.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Summoner_Name});
            this.lView_Spells.LabelEdit = true;
            this.lView_Spells.Location = new System.Drawing.Point(68, 170);
            this.lView_Spells.Name = "lView_Spells";
            this.lView_Spells.Size = new System.Drawing.Size(161, 336);
            this.lView_Spells.TabIndex = 21;
            this.lView_Spells.UseCompatibleStateImageBehavior = false;
            this.lView_Spells.View = System.Windows.Forms.View.Details;
            this.lView_Spells.SelectedIndexChanged += new System.EventHandler(this.lView_Spells_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Summoner_Name
            // 
            this.Summoner_Name.Text = "Summoner Name";
            this.Summoner_Name.Width = 150;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Location = new System.Drawing.Point(268, 261);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(484, 245);
            this.MainContentPanel.TabIndex = 22;
            // 
            // CooldownContentPanel
            // 
            this.CooldownContentPanel.Location = new System.Drawing.Point(268, 170);
            this.CooldownContentPanel.Name = "CooldownContentPanel";
            this.CooldownContentPanel.Size = new System.Drawing.Size(222, 28);
            this.CooldownContentPanel.TabIndex = 23;
            // 
            // Summoner_Spells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 535);
            this.Controls.Add(this.CooldownContentPanel);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.lView_Spells);
            this.Controls.Add(this.SpellsIconBox);
            this.Name = "Summoner_Spells";
            this.Text = "Summoner_Spells";
            this.Load += new System.EventHandler(this.Summoner_Spells_load);
            ((System.ComponentModel.ISupportInitialize)(this.SpellsIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SpellsIconBox;
        private System.Windows.Forms.ListView lView_Spells;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Summoner_Name;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel CooldownContentPanel;
    }
}