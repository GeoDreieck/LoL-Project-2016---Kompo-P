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
            this.ItemIconBox = new System.Windows.Forms.PictureBox();
            this.special_btn = new System.Windows.Forms.Button();
            this.stats_btn = new System.Windows.Forms.Button();
            this.build_btn = new System.Windows.Forms.Button();
            this.lView_Items = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.ParentItemPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemIconBox
            // 
            this.ItemIconBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemIconBox.Location = new System.Drawing.Point(72, 50);
            this.ItemIconBox.Name = "ItemIconBox";
            this.ItemIconBox.Size = new System.Drawing.Size(170, 115);
            this.ItemIconBox.TabIndex = 12;
            this.ItemIconBox.TabStop = false;
            // 
            // special_btn
            // 
            this.special_btn.Location = new System.Drawing.Point(248, 85);
            this.special_btn.Name = "special_btn";
            this.special_btn.Size = new System.Drawing.Size(90, 38);
            this.special_btn.TabIndex = 17;
            this.special_btn.Text = "Special ";
            this.special_btn.UseVisualStyleBackColor = true;
            this.special_btn.Click += new System.EventHandler(this.special_btn_Click);
            // 
            // stats_btn
            // 
            this.stats_btn.Location = new System.Drawing.Point(248, 50);
            this.stats_btn.Name = "stats_btn";
            this.stats_btn.Size = new System.Drawing.Size(90, 38);
            this.stats_btn.TabIndex = 18;
            this.stats_btn.Text = "Stats";
            this.stats_btn.UseVisualStyleBackColor = true;
            this.stats_btn.Click += new System.EventHandler(this.stats_btn_Click);
            // 
            // build_btn
            // 
            this.build_btn.Location = new System.Drawing.Point(248, 118);
            this.build_btn.Name = "build_btn";
            this.build_btn.Size = new System.Drawing.Size(90, 38);
            this.build_btn.TabIndex = 19;
            this.build_btn.Text = "Build ";
            this.build_btn.UseVisualStyleBackColor = true;
            this.build_btn.Click += new System.EventHandler(this.build_btn_Click);
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
            this.lView_Items.SelectedIndexChanged += new System.EventHandler(this.lView_Items_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Champion_name";
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Location = new System.Drawing.Point(261, 201);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(566, 322);
            this.MainContentPanel.TabIndex = 21;
            // 
            // ParentItemPanel
            // 
            this.ParentItemPanel.Location = new System.Drawing.Point(374, 50);
            this.ParentItemPanel.Name = "ParentItemPanel";
            this.ParentItemPanel.Size = new System.Drawing.Size(438, 115);
            this.ParentItemPanel.TabIndex = 22;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 568);
            this.Controls.Add(this.ParentItemPanel);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.lView_Items);
            this.Controls.Add(this.build_btn);
            this.Controls.Add(this.stats_btn);
            this.Controls.Add(this.special_btn);
            this.Controls.Add(this.ItemIconBox);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ItemIconBox;
        private System.Windows.Forms.Button special_btn;
        private System.Windows.Forms.Button stats_btn;
        private System.Windows.Forms.Button build_btn;
        private System.Windows.Forms.ListView lView_Items;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel ParentItemPanel;
    }
}