namespace WindowsFormsApplication1
{
    partial class UocBoiSo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtboi = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtuoc = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bội số chung nhỏ nhất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ước số chung lớn nhất:";
            // 
            // btnthuchien
            // 
            this.btnthuchien.Location = new System.Drawing.Point(12, 211);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(75, 23);
            this.btnthuchien.TabIndex = 5;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Location = new System.Drawing.Point(103, 211);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(75, 23);
            this.btntieptuc.TabIndex = 6;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(197, 211);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(92, 54);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 8;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            this.txta.Leave += new System.EventHandler(this.txta_Leave);
            // 
            // txtboi
            // 
            this.txtboi.Location = new System.Drawing.Point(157, 163);
            this.txtboi.Name = "txtboi";
            this.txtboi.ReadOnly = true;
            this.txtboi.Size = new System.Drawing.Size(35, 20);
            this.txtboi.TabIndex = 10;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(92, 90);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 11;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            this.txtb.Leave += new System.EventHandler(this.txtb_Leave);
            // 
            // txtuoc
            // 
            this.txtuoc.Location = new System.Drawing.Point(157, 129);
            this.txtuoc.Name = "txtuoc";
            this.txtuoc.ReadOnly = true;
            this.txtuoc.Size = new System.Drawing.Size(35, 20);
            this.txtuoc.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UocBoiSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtuoc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtboi);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UocBoiSo";
            this.Text = "Ước Số  - Bội Số ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UocBoiSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtboi;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtuoc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}