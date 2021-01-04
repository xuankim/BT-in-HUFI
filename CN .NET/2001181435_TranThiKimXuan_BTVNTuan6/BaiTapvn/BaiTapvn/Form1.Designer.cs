namespace BaiTapvn
{
    partial class Form1
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
            this.bai1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bai2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bai1ToolStripMenuItem,
            this.bai2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bai1ToolStripMenuItem
            // 
            this.bai1ToolStripMenuItem.Name = "bai1ToolStripMenuItem";
            this.bai1ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bai1ToolStripMenuItem.Text = "Bai1";
            this.bai1ToolStripMenuItem.Click += new System.EventHandler(this.bai1ToolStripMenuItem_Click);
            // 
            // bai2ToolStripMenuItem
            // 
            this.bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            this.bai2ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.bai2ToolStripMenuItem.Text = "Bai2";
            this.bai2ToolStripMenuItem.Click += new System.EventHandler(this.bai2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 588);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bai1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bai2ToolStripMenuItem;
    }
}

