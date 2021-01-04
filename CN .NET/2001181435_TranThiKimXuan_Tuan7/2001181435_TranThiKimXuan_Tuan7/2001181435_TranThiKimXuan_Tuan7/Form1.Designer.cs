namespace _2001181435_TranThiKimXuan_Tuan7
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
            this.bTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bTToolStripMenuItem
            // 
            this.bTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT1ToolStripMenuItem,
            this.bT2ToolStripMenuItem});
            this.bTToolStripMenuItem.Name = "bTToolStripMenuItem";
            this.bTToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.bTToolStripMenuItem.Text = "BT";
            // 
            // bT1ToolStripMenuItem
            // 
            this.bT1ToolStripMenuItem.Name = "bT1ToolStripMenuItem";
            this.bT1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bT1ToolStripMenuItem.Text = "BT1";
            this.bT1ToolStripMenuItem.Click += new System.EventHandler(this.bT1ToolStripMenuItem_Click);
            // 
            // bT2ToolStripMenuItem
            // 
            this.bT2ToolStripMenuItem.Name = "bT2ToolStripMenuItem";
            this.bT2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bT2ToolStripMenuItem.Text = "BT2";
            this.bT2ToolStripMenuItem.Click += new System.EventHandler(this.bT2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 556);
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
        private System.Windows.Forms.ToolStripMenuItem bTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT2ToolStripMenuItem;

    }
}

