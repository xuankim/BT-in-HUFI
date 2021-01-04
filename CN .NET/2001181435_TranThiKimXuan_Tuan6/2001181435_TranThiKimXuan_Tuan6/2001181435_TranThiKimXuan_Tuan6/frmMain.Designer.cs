namespace _2001181435_TranThiKimXuan_Tuan6
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baiTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baiTapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baiTapToolStripMenuItem
            // 
            this.baiTapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai3ToolStripMenuItem});
            this.baiTapToolStripMenuItem.Name = "baiTapToolStripMenuItem";
            this.baiTapToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.baiTapToolStripMenuItem.Text = "Bai Tap";
            // 
            // bai3ToolStripMenuItem
            // 
            this.bai3ToolStripMenuItem.Name = "bai3ToolStripMenuItem";
            this.bai3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bai3ToolStripMenuItem.Text = "Bai 3";
            this.bai3ToolStripMenuItem.Click += new System.EventHandler(this.bai3ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 424);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";            
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baiTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai3ToolStripMenuItem;
    }
}