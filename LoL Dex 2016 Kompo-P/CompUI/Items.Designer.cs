namespace CompUI
{
    partial class Items
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
            this.item_picture = new System.Windows.Forms.PictureBox();
            this.build_path_picture = new System.Windows.Forms.PictureBox();
            this.special_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.build_btn = new System.Windows.Forms.Button();
            this.lView_Items = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.build_path_picture)).BeginInit();
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
            this.lView_Content.Location = new System.Drawing.Point(399, 201);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(439, 322);
            this.lView_Content.TabIndex = 13;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            // 
            // item_picture
            // 
            this.item_picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.item_picture.Location = new System.Drawing.Point(72, 50);
            this.item_picture.Name = "item_picture";
            this.item_picture.Size = new System.Drawing.Size(170, 115);
            this.item_picture.TabIndex = 12;
            this.item_picture.TabStop = false;
            // 
            // build_path_picture
            // 
            this.build_path_picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.build_path_picture.Location = new System.Drawing.Point(399, 50);
            this.build_path_picture.Name = "build_path_picture";
            this.build_path_picture.Size = new System.Drawing.Size(428, 115);
            this.build_path_picture.TabIndex = 15;
            this.build_path_picture.TabStop = false;
            // 
            // special_btn
            // 
            this.special_btn.Location = new System.Drawing.Point(248, 85);
            this.special_btn.Name = "special_btn";
            this.special_btn.Size = new System.Drawing.Size(90, 38);
            this.special_btn.TabIndex = 17;
            this.special_btn.Text = "Special ";
            this.special_btn.UseVisualStyleBackColor = true;
            // 
            // stats_btn
            // 
            this.stats_btn.Location = new System.Drawing.Point(248, 50);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(90, 38);
            this.stats_btn.TabIndex = 18;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = true;
            this.stats_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // build_btn
            // 
            this.build_btn.Location = new System.Drawing.Point(248, 118);
            this.build_btn.Name = "build_btn";
            this.build_btn.Size = new System.Drawing.Size(90, 38);
            this.build_btn.TabIndex = 19;
            this.build_btn.Text = "Build ";
            this.build_btn.UseVisualStyleBackColor = true;
            // 
            // lView_Items
            // 
            this.lView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lView_Items.LabelEdit = true;
            this.lView_Items.Location = new System.Drawing.Point(72, 201);
            this.lView_Items.Name = "lView_Items";
            this.lView_Items.Size = new System.Drawing.Size(161, 322);
            this.lView_Items.TabIndex = 20;
            this.lView_Items.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Champion_name";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 568);
            this.Controls.Add(this.lView_Items);
            this.Controls.Add(this.build_btn);
            this.Controls.Add(this.stats_btn);
            this.Controls.Add(this.special_btn);
            this.Controls.Add(this.build_path_picture);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.item_picture);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.build_path_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.PictureBox item_picture;
        private System.Windows.Forms.PictureBox build_path_picture;
        private System.Windows.Forms.Button special_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.Button build_btn;
        private System.Windows.Forms.ListView lView_Items;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}