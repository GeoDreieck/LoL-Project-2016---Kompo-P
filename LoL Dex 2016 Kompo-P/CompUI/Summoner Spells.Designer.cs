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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Right);
            this.lView_Content = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maps_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.lView_Spells = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lView_Content.Location = new System.Drawing.Point(311, 114);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(401, 392);
            this.lView_Content.TabIndex = 20;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(68, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 115);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // maps_btn
            // 
            this.maps_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.maps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maps_btn.Location = new System.Drawing.Point(511, 29);
            this.maps_btn.Name = "maps_btn";
            this.maps_btn.Size = new System.Drawing.Size(168, 29);
            this.maps_btn.TabIndex = 17;
            this.maps_btn.Text = "Maps";
            this.maps_btn.UseVisualStyleBackColor = false;
            this.maps_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // stats_btn
            // 
            this.stats_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stats_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_btn.Location = new System.Drawing.Point(346, 29);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(168, 29);
            this.stats_btn.TabIndex = 15;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = false;
            // 
            // lView_Spells
            // 
            this.lView_Spells.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lView_Spells.LabelEdit = true;
            this.lView_Spells.Location = new System.Drawing.Point(68, 170);
            this.lView_Spells.Name = "lView_Spells";
            this.lView_Spells.Size = new System.Drawing.Size(161, 336);
            this.lView_Spells.TabIndex = 21;
            this.lView_Spells.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Champion_name";
            // 
            // Summoner_Spells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 535);
            this.Controls.Add(this.lView_Spells);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maps_btn);
            this.Controls.Add(this.stats_btn);
            this.Name = "Summoner_Spells";
            this.Text = "Summoner_Spells";
            this.Load += new System.EventHandler(this.Summoner_Spells_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button maps_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.ListView lView_Spells;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}