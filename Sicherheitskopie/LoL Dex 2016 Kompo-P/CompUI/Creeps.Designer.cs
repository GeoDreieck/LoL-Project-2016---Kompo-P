namespace CompUI
{
    partial class Creeps
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
            this.CreepsIconBox = new System.Windows.Forms.PictureBox();
            this.lView_creeps = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainContentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CreepsIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreepsIconBox
            // 
            this.CreepsIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreepsIconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreepsIconBox.Location = new System.Drawing.Point(31, 12);
            this.CreepsIconBox.Name = "CreepsIconBox";
            this.CreepsIconBox.Size = new System.Drawing.Size(133, 133);
            this.CreepsIconBox.TabIndex = 12;
            this.CreepsIconBox.TabStop = false;
            // 
            // lView_creeps
            // 
            this.lView_creeps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CreepName});
            this.lView_creeps.LabelEdit = true;
            this.lView_creeps.Location = new System.Drawing.Point(31, 171);
            this.lView_creeps.Name = "lView_creeps";
            this.lView_creeps.Size = new System.Drawing.Size(161, 336);
            this.lView_creeps.TabIndex = 14;
            this.lView_creeps.UseCompatibleStateImageBehavior = false;
            this.lView_creeps.View = System.Windows.Forms.View.Details;
            this.lView_creeps.SelectedIndexChanged += new System.EventHandler(this.lView_creeps_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // CreepName
            // 
            this.CreepName.Text = "Creep Name";
            this.CreepName.Width = 150;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainContentPanel.Location = new System.Drawing.Point(282, 160);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(421, 336);
            this.MainContentPanel.TabIndex = 15;
            // 
            // Creeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompUI.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(766, 508);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.lView_creeps);
            this.Controls.Add(this.CreepsIconBox);
            this.Name = "Creeps";
            this.Text = "Creeps";
            this.Load += new System.EventHandler(this.Creeps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CreepsIconBox)).EndInit();
            this.ResumeLayout(false);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

        }

        #endregion
        private System.Windows.Forms.PictureBox CreepsIconBox;
        private System.Windows.Forms.ListView lView_creeps;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CreepName;
        private System.Windows.Forms.Panel MainContentPanel;
    }
}