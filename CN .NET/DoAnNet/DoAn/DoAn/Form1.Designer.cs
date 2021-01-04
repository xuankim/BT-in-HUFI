namespace DoAn
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
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taohoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem1,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSảnPhẩmToolStripMenuItem,
            this.PNToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hóaĐơnToolStripMenuItem.Text = "Sản phẩm";
            // 
            // danhSáchSảnPhẩmToolStripMenuItem
            // 
            this.danhSáchSảnPhẩmToolStripMenuItem.Name = "danhSáchSảnPhẩmToolStripMenuItem";
            this.danhSáchSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.danhSáchSảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.danhSáchSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.danhSáchSảnPhẩmToolStripMenuItem_Click);
            // 
            // PNToolStripMenuItem
            // 
            this.PNToolStripMenuItem.Name = "PNToolStripMenuItem";
            this.PNToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.PNToolStripMenuItem.Text = "Phiếu nhập hàng";
            this.PNToolStripMenuItem.Click += new System.EventHandler(this.PNToolStripMenuItem_Click_1);
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            this.hóaĐơnToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taohoadonToolStripMenuItem,
            this.xemLịchSửToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            this.hóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
            // 
            // taohoadonToolStripMenuItem
            // 
            this.taohoadonToolStripMenuItem.Name = "taohoadonToolStripMenuItem";
            this.taohoadonToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.taohoadonToolStripMenuItem.Text = "Tạo hóa đơn";
            this.taohoadonToolStripMenuItem.Click += new System.EventHandler(this.taohoadonToolStripMenuItem_Click);
            // 
            // xemLịchSửToolStripMenuItem
            // 
            this.xemLịchSửToolStripMenuItem.Name = "xemLịchSửToolStripMenuItem";
            this.xemLịchSửToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.xemLịchSửToolStripMenuItem.Text = "Xem lịch sử ";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DoAn.Properties.Resources.slide_index_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(924, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taohoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;

    }
}

