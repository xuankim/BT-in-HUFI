namespace _2001181435_TranThiKimXuan_Tuan4
{
    partial class Tinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.rdcong = new System.Windows.Forms.RadioButton();
            this.rdtru = new System.Windows.Forms.RadioButton();
            this.rdnhan = new System.Windows.Forms.RadioButton();
            this.rdchia = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(67, 22);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(78, 20);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(202, 22);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(80, 20);
            this.txtb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ket qua";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(67, 57);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(205, 20);
            this.txtkq.TabIndex = 5;
            // 
            // rdcong
            // 
            this.rdcong.AutoSize = true;
            this.rdcong.Location = new System.Drawing.Point(16, 92);
            this.rdcong.Name = "rdcong";
            this.rdcong.Size = new System.Drawing.Size(31, 17);
            this.rdcong.TabIndex = 6;
            this.rdcong.TabStop = true;
            this.rdcong.Text = "+";
            this.rdcong.UseVisualStyleBackColor = true;
            // 
            // rdtru
            // 
            this.rdtru.AutoSize = true;
            this.rdtru.Location = new System.Drawing.Point(88, 92);
            this.rdtru.Name = "rdtru";
            this.rdtru.Size = new System.Drawing.Size(28, 17);
            this.rdtru.TabIndex = 7;
            this.rdtru.TabStop = true;
            this.rdtru.Text = "-";
            this.rdtru.UseVisualStyleBackColor = true;
            // 
            // rdnhan
            // 
            this.rdnhan.AutoSize = true;
            this.rdnhan.Location = new System.Drawing.Point(154, 92);
            this.rdnhan.Name = "rdnhan";
            this.rdnhan.Size = new System.Drawing.Size(30, 17);
            this.rdnhan.TabIndex = 8;
            this.rdnhan.TabStop = true;
            this.rdnhan.Text = "x";
            this.rdnhan.UseVisualStyleBackColor = true;
            // 
            // rdchia
            // 
            this.rdchia.AutoSize = true;
            this.rdchia.Location = new System.Drawing.Point(222, 92);
            this.rdchia.Name = "rdchia";
            this.rdchia.Size = new System.Drawing.Size(30, 17);
            this.rdchia.TabIndex = 9;
            this.rdchia.TabStop = true;
            this.rdchia.Text = "/";
            this.rdchia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tinh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdchia);
            this.Controls.Add(this.rdnhan);
            this.Controls.Add(this.rdtru);
            this.Controls.Add(this.rdcong);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cong tru nhan chia Radio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tinh_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.RadioButton rdcong;
        private System.Windows.Forms.RadioButton rdtru;
        private System.Windows.Forms.RadioButton rdnhan;
        private System.Windows.Forms.RadioButton rdchia;
        private System.Windows.Forms.Button button1;
    }
}