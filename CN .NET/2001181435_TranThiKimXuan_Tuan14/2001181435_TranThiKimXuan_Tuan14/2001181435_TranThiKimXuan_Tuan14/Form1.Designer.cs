namespace _2001181435_TranThiKimXuan_Tuan14
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
            this.btnketnoi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenmay = new System.Windows.Forms.TextBox();
            this.txttencsdl = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(79, 218);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(75, 23);
            this.btnketnoi.TabIndex = 0;
            this.btnketnoi.Text = "Kết nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên CSDL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // txttenmay
            // 
            this.txttenmay.Location = new System.Drawing.Point(110, 72);
            this.txttenmay.Name = "txttenmay";
            this.txttenmay.Size = new System.Drawing.Size(188, 20);
            this.txttenmay.TabIndex = 6;
            // 
            // txttencsdl
            // 
            this.txttencsdl.Location = new System.Drawing.Point(110, 102);
            this.txttencsdl.Name = "txttencsdl";
            this.txttencsdl.Size = new System.Drawing.Size(188, 20);
            this.txttencsdl.TabIndex = 7;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(110, 134);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(188, 20);
            this.txtuser.TabIndex = 8;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(110, 162);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(188, 20);
            this.txtpass.TabIndex = 9;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 314);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txttencsdl);
            this.Controls.Add(this.txttenmay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnketnoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenmay;
        private System.Windows.Forms.TextBox txttencsdl;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
    }
}

