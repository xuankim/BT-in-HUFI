namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblbirth = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(32, 49);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(60, 13);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Your Name";
            // 
            // lblbirth
            // 
            this.lblbirth.AutoSize = true;
            this.lblbirth.Location = new System.Drawing.Point(32, 90);
            this.lblbirth.Name = "lblbirth";
            this.lblbirth.Size = new System.Drawing.Size(64, 13);
            this.lblbirth.TabIndex = 1;
            this.lblbirth.Text = "Year of birth";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(101, 49);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(409, 20);
            this.txthoten.TabIndex = 2;
            this.txthoten.Leave += new System.EventHandler(this.txthoten_Leave);
            // 
            // txtbirth
            // 
            this.txtbirth.Location = new System.Drawing.Point(101, 90);
            this.txtbirth.MaxLength = 4;
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.Size = new System.Drawing.Size(409, 20);
            this.txtbirth.TabIndex = 3;
            this.txtbirth.TextChanged += new System.EventHandler(this.txtbirth_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(35, 154);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(94, 32);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(219, 154);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 32);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Clear";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(391, 154);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(94, 32);
            this.btndong.TabIndex = 6;
            this.btndong.Text = "Exit";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 194);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtbirth);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.lblbirth);
            this.Controls.Add(this.lblHoten);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblbirth;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

