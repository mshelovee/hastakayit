namespace hastane__96
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbBilgiler = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbKan = new System.Windows.Forms.ComboBox();
            this.rbHastalikYok = new System.Windows.Forms.RadioButton();
            this.rbHastalikVar = new System.Windows.Forms.RadioButton();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKaydet.Location = new System.Drawing.Point(12, 379);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(192, 46);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbBilgiler
            // 
            this.lbBilgiler.FormattingEnabled = true;
            this.lbBilgiler.Location = new System.Drawing.Point(12, 12);
            this.lbBilgiler.Name = "lbBilgiler";
            this.lbBilgiler.Size = new System.Drawing.Size(192, 342);
            this.lbBilgiler.TabIndex = 34;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAktar.Location = new System.Drawing.Point(305, 311);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(121, 48);
            this.btnAktar.TabIndex = 33;
            this.btnAktar.Text = "AKTAR";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kan Grup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kronik Hastalık";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(305, 270);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 29;
            // 
            // cmbKan
            // 
            this.cmbKan.FormattingEnabled = true;
            this.cmbKan.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0-",
            "0+"});
            this.cmbKan.Location = new System.Drawing.Point(305, 226);
            this.cmbKan.Name = "cmbKan";
            this.cmbKan.Size = new System.Drawing.Size(121, 21);
            this.cmbKan.TabIndex = 28;
            // 
            // rbHastalikYok
            // 
            this.rbHastalikYok.AutoSize = true;
            this.rbHastalikYok.Location = new System.Drawing.Point(305, 195);
            this.rbHastalikYok.Name = "rbHastalikYok";
            this.rbHastalikYok.Size = new System.Drawing.Size(118, 17);
            this.rbHastalikYok.TabIndex = 27;
            this.rbHastalikYok.TabStop = true;
            this.rbHastalikYok.Text = "Kronik Hastalık Yok";
            this.rbHastalikYok.UseVisualStyleBackColor = true;
            // 
            // rbHastalikVar
            // 
            this.rbHastalikVar.AutoSize = true;
            this.rbHastalikVar.Location = new System.Drawing.Point(305, 172);
            this.rbHastalikVar.Name = "rbHastalikVar";
            this.rbHastalikVar.Size = new System.Drawing.Size(115, 17);
            this.rbHastalikVar.TabIndex = 26;
            this.rbHastalikVar.TabStop = true;
            this.rbHastalikVar.Text = "Kronik Hastalık Var";
            this.rbHastalikVar.UseVisualStyleBackColor = true;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(305, 126);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(305, 88);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tc no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tel no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(262, 24);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(305, 53);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 19;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(305, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lbBilgiler);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbKan);
            this.Controls.Add(this.rbHastalikYok);
            this.Controls.Add(this.rbHastalikVar);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lbBilgiler;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbKan;
        private System.Windows.Forms.RadioButton rbHastalikYok;
        private System.Windows.Forms.RadioButton rbHastalikVar;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
    }
}

