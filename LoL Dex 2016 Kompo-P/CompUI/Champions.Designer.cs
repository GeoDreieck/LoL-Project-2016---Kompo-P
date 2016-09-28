﻿namespace CompUI
{
    partial class Champions
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
            this.stats_btn = new System.Windows.Forms.Button();
            this.spells_btn = new System.Windows.Forms.Button();
            this.tipps_btn = new System.Windows.Forms.Button();
            this.story_btn = new System.Windows.Forms.Button();
            this.ChampIconBox = new System.Windows.Forms.PictureBox();
            this.lView_Content = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lView_Champnames = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ChampIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stats_btn
            // 
            this.stats_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stats_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_btn.Location = new System.Drawing.Point(309, 26);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(168, 29);
            this.stats_btn.TabIndex = 0;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = false;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            // 
            // spells_btn
            // 
            this.spells_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spells_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.spells_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spells_btn.Location = new System.Drawing.Point(309, 51);
            this.spells_btn.Name = "spells_btn";
            this.spells_btn.Size = new System.Drawing.Size(168, 29);
            this.spells_btn.TabIndex = 1;
            this.spells_btn.Text = "Spells";
            this.spells_btn.UseVisualStyleBackColor = false;
            // 
            // tipps_btn
            // 
            this.tipps_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tipps_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipps_btn.Location = new System.Drawing.Point(474, 26);
            this.tipps_btn.Name = "tipps_btn";
            this.tipps_btn.Size = new System.Drawing.Size(168, 29);
            this.tipps_btn.TabIndex = 2;
            this.tipps_btn.Text = "Tipps";
            this.tipps_btn.UseVisualStyleBackColor = false;
            this.tipps_btn.Click += new System.EventHandler(this.tipps_btn_Click);
            // 
            // story_btn
            // 
            this.story_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.story_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.story_btn.Location = new System.Drawing.Point(474, 52);
            this.story_btn.Name = "story_btn";
            this.story_btn.Size = new System.Drawing.Size(168, 29);
            this.story_btn.TabIndex = 3;
            this.story_btn.Text = "Story";
            this.story_btn.UseVisualStyleBackColor = false;
            // 
            // ChampIconBox
            // 
            this.ChampIconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChampIconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ChampIconBox.Location = new System.Drawing.Point(31, 12);
            this.ChampIconBox.Name = "ChampIconBox";
            this.ChampIconBox.Size = new System.Drawing.Size(133, 133);
            this.ChampIconBox.TabIndex = 4;
            this.ChampIconBox.TabStop = false;
            this.ChampIconBox.Click += new System.EventHandler(this.ChampIconBox_Click);
            // 
            // lView_Content
            // 
            this.lView_Content.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lView_Content.LabelEdit = true;
            this.lView_Content.Location = new System.Drawing.Point(309, 114);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(401, 392);
            this.lView_Content.TabIndex = 6;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            this.lView_Content.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Champion_name";
            // 
            // lView_Champnames
            // 
            this.lView_Champnames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name});
            this.lView_Champnames.LabelEdit = true;
            this.lView_Champnames.Location = new System.Drawing.Point(31, 170);
            this.lView_Champnames.MultiSelect = false;
            this.lView_Champnames.Name = "lView_Champnames";
            this.lView_Champnames.Size = new System.Drawing.Size(133, 336);
            this.lView_Champnames.TabIndex = 7;
            this.lView_Champnames.UseCompatibleStateImageBehavior = false;
            this.lView_Champnames.View = System.Windows.Forms.View.Details;
            this.lView_Champnames.SelectedIndexChanged += new System.EventHandler(this.lView_Champnames_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.Text = "Champions";
            this.name.Width = 150;
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(762, 546);
            this.Controls.Add(this.lView_Champnames);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.ChampIconBox);
            this.Controls.Add(this.story_btn);
            this.Controls.Add(this.tipps_btn);
            this.Controls.Add(this.spells_btn);
            this.Controls.Add(this.stats_btn);
            this.Name = "Champions";
            this.Text = "Champions";
            this.Load += new System.EventHandler(this.Champions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChampIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.Button spells_btn;
        private System.Windows.Forms.Button tipps_btn;
        private System.Windows.Forms.Button story_btn;
        private System.Windows.Forms.PictureBox ChampIconBox;
        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lView_Champnames;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;


    }
}