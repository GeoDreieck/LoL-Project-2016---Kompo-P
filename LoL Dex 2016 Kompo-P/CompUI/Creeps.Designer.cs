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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Right);
            this.lView_Content = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spells_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.lView_creeps = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lView_Content
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            listViewGroup2.Name = "listViewGroup2";
            this.lView_Content.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lView_Content.Location = new System.Drawing.Point(304, 101);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(401, 392);
            this.lView_Content.TabIndex = 13;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(61, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 115);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // spells_btn
            // 
            this.spells_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spells_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.spells_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spells_btn.Location = new System.Drawing.Point(509, 45);
            this.spells_btn.Name = "spells_btn";
            this.spells_btn.Size = new System.Drawing.Size(168, 29);
            this.spells_btn.TabIndex = 9;
            this.spells_btn.Text = "Spells";
            this.spells_btn.UseVisualStyleBackColor = false;
            // 
            // stats_btn
            // 
            this.stats_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stats_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_btn.Location = new System.Drawing.Point(316, 45);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(168, 29);
            this.stats_btn.TabIndex = 8;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = false;
            // 
            // lView_creeps
            // 
            this.lView_creeps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.CreepName});
            this.lView_creeps.LabelEdit = true;
            this.lView_creeps.Location = new System.Drawing.Point(61, 160);
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
            // Creeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 508);
            this.Controls.Add(this.lView_creeps);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.spells_btn);
            this.Controls.Add(this.stats_btn);
            this.Name = "Creeps";
            this.Text = "Creeps";
            this.Load += new System.EventHandler(this.Creeps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button spells_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.ListView lView_creeps;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader CreepName;
    }
}