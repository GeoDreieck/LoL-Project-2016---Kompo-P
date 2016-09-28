namespace CompUI
{
    partial class Masteries
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
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.Tree3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree3)).BeginInit();
            this.SuspendLayout();
            // 
            // Tree1
            // 
            this.Tree1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tree1.Location = new System.Drawing.Point(57, 47);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(210, 408);
            this.Tree1.TabIndex = 0;
            this.Tree1.TabStop = false;
            // 
            // Tree2
            // 
            this.Tree2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tree2.Location = new System.Drawing.Point(283, 47);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(210, 408);
            this.Tree2.TabIndex = 1;
            this.Tree2.TabStop = false;
            // 
            // Tree3
            // 
            this.Tree3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tree3.Location = new System.Drawing.Point(509, 47);
            this.Tree3.Name = "Tree3";
            this.Tree3.Size = new System.Drawing.Size(210, 408);
            this.Tree3.TabIndex = 2;
            this.Tree3.TabStop = false;
            // 
            // Masteries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.Tree3);
            this.Controls.Add(this.Tree2);
            this.Controls.Add(this.Tree1);
            this.Name = "Masteries";
            this.Text = "Masteries";
            this.Load += new System.EventHandler(this.Masteries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Tree2;
        private System.Windows.Forms.PictureBox Tree3;
    }
}