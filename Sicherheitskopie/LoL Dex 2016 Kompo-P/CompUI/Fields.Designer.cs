namespace CompUI
{
    partial class Fields
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
            this.special_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.rules_btn = new System.Windows.Forms.Button();
            this.monster_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lView_fields = new System.Windows.Forms.ListView();
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
            this.lView_Content.Location = new System.Drawing.Point(289, 103);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(401, 392);
            this.lView_Content.TabIndex = 13;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            // 
            // special_btn
            // 
            this.special_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.special_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.special_btn.Location = new System.Drawing.Point(489, 44);
            this.special_btn.Name = "special_btn";
            this.special_btn.Size = new System.Drawing.Size(168, 29);
            this.special_btn.TabIndex = 11;
            this.special_btn.Text = "Special";
            this.special_btn.UseVisualStyleBackColor = false;
            // 
            // items_btn
            // 
            this.items_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.items_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.items_btn.Location = new System.Drawing.Point(489, 18);
            this.items_btn.Name = "items_btn";
            this.items_btn.Size = new System.Drawing.Size(168, 29);
            this.items_btn.TabIndex = 10;
            this.items_btn.Text = "Items";
            this.items_btn.UseVisualStyleBackColor = false;
            // 
            // rules_btn
            // 
            this.rules_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rules_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rules_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_btn.Location = new System.Drawing.Point(324, 43);
            this.rules_btn.Name = "rules_btn";
            this.rules_btn.Size = new System.Drawing.Size(168, 29);
            this.rules_btn.TabIndex = 9;
            this.rules_btn.Text = "Rules";
            this.rules_btn.UseVisualStyleBackColor = false;
            // 
            // monster_btn
            // 
            this.monster_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monster_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.monster_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monster_btn.Location = new System.Drawing.Point(324, 18);
            this.monster_btn.Name = "monster_btn";
            this.monster_btn.Size = new System.Drawing.Size(168, 29);
            this.monster_btn.TabIndex = 8;
            this.monster_btn.Text = "Monster";
            this.monster_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(46, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 115);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lView_fields
            // 
            this.lView_fields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lView_fields.LabelEdit = true;
            this.lView_fields.Location = new System.Drawing.Point(46, 159);
            this.lView_fields.Name = "lView_fields";
            this.lView_fields.Size = new System.Drawing.Size(161, 336);
            this.lView_fields.TabIndex = 14;
            this.lView_fields.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Champion_name";
            // 
            // Fields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 512);
            this.Controls.Add(this.lView_fields);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.special_btn);
            this.Controls.Add(this.items_btn);
            this.Controls.Add(this.rules_btn);
            this.Controls.Add(this.monster_btn);
            this.Name = "Fields";
            this.Text = "Fields";
            this.Load += new System.EventHandler(this.Fields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.Button special_btn;
        private System.Windows.Forms.Button items_btn;
        private System.Windows.Forms.Button rules_btn;
        private System.Windows.Forms.Button monster_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lView_fields;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}