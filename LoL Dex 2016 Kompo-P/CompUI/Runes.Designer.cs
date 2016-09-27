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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Right);
            this.lView_Content = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rune_level_box = new System.Windows.Forms.ComboBox();
            this.rune_proberty_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lView_Runes = new System.Windows.Forms.ListView();
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
            this.lView_Content.Location = new System.Drawing.Point(295, 109);
            this.lView_Content.Name = "lView_Content";
            this.lView_Content.Size = new System.Drawing.Size(401, 392);
            this.lView_Content.TabIndex = 13;
            this.lView_Content.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(52, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 115);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            this.rune_level_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.columnHeader3,
            this.columnHeader4});
            this.lView_Runes.LabelEdit = true;
            this.lView_Runes.Location = new System.Drawing.Point(52, 165);
            this.lView_Runes.Name = "lView_Runes";
            this.lView_Runes.Size = new System.Drawing.Size(161, 336);
            this.lView_Runes.TabIndex = 19;
            this.lView_Runes.UseCompatibleStateImageBehavior = false;
            this.lView_Runes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Champion_name";
            // 
            // Runes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 525);
            this.Controls.Add(this.lView_Runes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rune_proberty_box);
            this.Controls.Add(this.rune_level_box);
            this.Controls.Add(this.lView_Content);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Runes";
            this.Text = "Runes";
            this.Load += new System.EventHandler(this.Runes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lView_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox rune_level_box;
        private System.Windows.Forms.ComboBox rune_proberty_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lView_Runes;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}