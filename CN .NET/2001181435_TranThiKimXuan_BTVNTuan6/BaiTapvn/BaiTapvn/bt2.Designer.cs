namespace BaiTapvn
{
    partial class bt2
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
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.radionam = new System.Windows.Forms.RadioButton();
            this.radionu = new System.Windows.Forms.RadioButton();
            this.ckanh = new System.Windows.Forms.CheckBox();
            this.checkBoxphap = new System.Windows.Forms.CheckBox();
            this.chkhoa = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbgioitinh = new System.Windows.Forms.Label();
            this.lbngoaingu = new System.Windows.Forms.Label();
            this.lbdantoc = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(166, 60);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(313, 20);
            this.txthoten.TabIndex = 0;
            // 
            // txtmaso
            // 
            this.txtmaso.Location = new System.Drawing.Point(166, 104);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(313, 20);
            this.txtmaso.TabIndex = 1;
            // 
            // radionam
            // 
            this.radionam.AutoSize = true;
            this.radionam.Location = new System.Drawing.Point(241, 159);
            this.radionam.Name = "radionam";
            this.radionam.Size = new System.Drawing.Size(47, 17);
            this.radionam.TabIndex = 2;
            this.radionam.TabStop = true;
            this.radionam.Text = "Nam";
            this.radionam.UseVisualStyleBackColor = true;
            this.radionam.CheckedChanged += new System.EventHandler(this.radionam_CheckedChanged);
            // 
            // radionu
            // 
            this.radionu.AutoSize = true;
            this.radionu.Location = new System.Drawing.Point(368, 157);
            this.radionu.Name = "radionu";
            this.radionu.Size = new System.Drawing.Size(39, 17);
            this.radionu.TabIndex = 3;
            this.radionu.TabStop = true;
            this.radionu.Text = "Nữ";
            this.radionu.UseVisualStyleBackColor = true;
            this.radionu.CheckedChanged += new System.EventHandler(this.radionu_CheckedChanged);
            // 
            // ckanh
            // 
            this.ckanh.AutoSize = true;
            this.ckanh.Location = new System.Drawing.Point(241, 188);
            this.ckanh.Name = "ckanh";
            this.ckanh.Size = new System.Drawing.Size(45, 17);
            this.ckanh.TabIndex = 5;
            this.ckanh.Text = "Anh";
            this.ckanh.UseVisualStyleBackColor = true;
            this.ckanh.CheckedChanged += new System.EventHandler(this.ckanh_CheckedChanged);
            // 
            // checkBoxphap
            // 
            this.checkBoxphap.AutoSize = true;
            this.checkBoxphap.Location = new System.Drawing.Point(368, 184);
            this.checkBoxphap.Name = "checkBoxphap";
            this.checkBoxphap.Size = new System.Drawing.Size(51, 17);
            this.checkBoxphap.TabIndex = 6;
            this.checkBoxphap.Text = "Pháp";
            this.checkBoxphap.UseVisualStyleBackColor = true;
            this.checkBoxphap.CheckedChanged += new System.EventHandler(this.checkBoxphap_CheckedChanged);
            // 
            // chkhoa
            // 
            this.chkhoa.AutoSize = true;
            this.chkhoa.Location = new System.Drawing.Point(487, 188);
            this.chkhoa.Name = "chkhoa";
            this.chkhoa.Size = new System.Drawing.Size(46, 17);
            this.chkhoa.TabIndex = 7;
            this.chkhoa.Text = "Hoa";
            this.chkhoa.UseVisualStyleBackColor = true;
            this.chkhoa.CheckedChanged += new System.EventHandler(this.chkhoa_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 221);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 248);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(561, 190);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ho ten";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ma sinh vien";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gioi tinh";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngoai ngu";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dan toc";
            this.columnHeader5.Width = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ho ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ma sinh vien";
            // 
            // lbgioitinh
            // 
            this.lbgioitinh.AutoSize = true;
            this.lbgioitinh.Location = new System.Drawing.Point(98, 159);
            this.lbgioitinh.Name = "lbgioitinh";
            this.lbgioitinh.Size = new System.Drawing.Size(47, 13);
            this.lbgioitinh.TabIndex = 16;
            this.lbgioitinh.Text = "Giới tính";
            // 
            // lbngoaingu
            // 
            this.lbngoaingu.AutoSize = true;
            this.lbngoaingu.Location = new System.Drawing.Point(98, 192);
            this.lbngoaingu.Name = "lbngoaingu";
            this.lbngoaingu.Size = new System.Drawing.Size(56, 13);
            this.lbngoaingu.TabIndex = 17;
            this.lbngoaingu.Text = "Ngoại ngữ";
            // 
            // lbdantoc
            // 
            this.lbdantoc.AutoSize = true;
            this.lbdantoc.Location = new System.Drawing.Point(98, 224);
            this.lbdantoc.Name = "lbdantoc";
            this.lbdantoc.Size = new System.Drawing.Size(45, 13);
            this.lbdantoc.TabIndex = 18;
            this.lbdantoc.Text = "Dân tộc";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(32, 465);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 19;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(458, 465);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 494);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.lbdantoc);
            this.Controls.Add(this.lbngoaingu);
            this.Controls.Add(this.lbgioitinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkhoa);
            this.Controls.Add(this.checkBoxphap);
            this.Controls.Add(this.ckanh);
            this.Controls.Add(this.radionu);
            this.Controls.Add(this.radionam);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.txthoten);
            this.Name = "bt2";
            this.Text = "Nam";
            this.Load += new System.EventHandler(this.bt2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.TextBox txthoten;
            private System.Windows.Forms.TextBox txtmaso;
            private System.Windows.Forms.RadioButton radionam;
            private System.Windows.Forms.RadioButton radionu;
            private System.Windows.Forms.CheckBox ckanh;
            private System.Windows.Forms.CheckBox checkBoxphap;
            private System.Windows.Forms.CheckBox chkhoa;
            private System.Windows.Forms.ComboBox comboBox1;
            private System.Windows.Forms.ListView listView1;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.ColumnHeader columnHeader3;
            private System.Windows.Forms.ColumnHeader columnHeader4;
            private System.Windows.Forms.ColumnHeader columnHeader5;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label lbgioitinh;
            private System.Windows.Forms.Label lbngoaingu;
            private System.Windows.Forms.Label lbdantoc;
            private System.Windows.Forms.Button btthem;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button btnsua;
        }
    
}