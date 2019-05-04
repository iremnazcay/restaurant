namespace restaurant
{
    partial class frmPersonelIslemleri
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
            this.groupBoxP1 = new System.Windows.Forms.GroupBox();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.cbPersoneller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerYeniSifre = new System.Windows.Forms.TextBox();
            this.txtPerSifre = new System.Windows.Forms.TextBox();
            this.groupBoxP2 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtGorevID = new System.Windows.Forms.TextBox();
            this.btnPerGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.cbGorevPersonel = new System.Windows.Forms.ComboBox();
            this.txtPersonelSifreT = new System.Windows.Forms.TextBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lwPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMasalarCıkıs = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.labelPersonel = new System.Windows.Forms.Label();
            this.groupBoxP1.SuspendLayout();
            this.groupBoxP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxP1
            // 
            this.groupBoxP1.Controls.Add(this.btnSifreDegistir);
            this.groupBoxP1.Controls.Add(this.txtKullaniciID);
            this.groupBoxP1.Controls.Add(this.cbPersoneller);
            this.groupBoxP1.Controls.Add(this.label2);
            this.groupBoxP1.Controls.Add(this.label1);
            this.groupBoxP1.Controls.Add(this.txtPerYeniSifre);
            this.groupBoxP1.Controls.Add(this.txtPerSifre);
            this.groupBoxP1.Location = new System.Drawing.Point(13, 47);
            this.groupBoxP1.Name = "groupBoxP1";
            this.groupBoxP1.Size = new System.Drawing.Size(324, 320);
            this.groupBoxP1.TabIndex = 0;
            this.groupBoxP1.TabStop = false;
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.BackColor = System.Drawing.Color.Orange;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.Location = new System.Drawing.Point(119, 242);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(152, 44);
            this.btnSifreDegistir.TabIndex = 7;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(277, 74);
            this.txtKullaniciID.Multiline = true;
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(14, 24);
            this.txtKullaniciID.TabIndex = 5;
            // 
            // cbPersoneller
            // 
            this.cbPersoneller.FormattingEnabled = true;
            this.cbPersoneller.Location = new System.Drawing.Point(119, 74);
            this.cbPersoneller.Name = "cbPersoneller";
            this.cbPersoneller.Size = new System.Drawing.Size(152, 24);
            this.cbPersoneller.TabIndex = 4;
            this.cbPersoneller.SelectedIndexChanged += new System.EventHandler(this.cbPersoneller_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Şifre:";
            // 
            // txtPerYeniSifre
            // 
            this.txtPerYeniSifre.Location = new System.Drawing.Point(119, 162);
            this.txtPerYeniSifre.Multiline = true;
            this.txtPerYeniSifre.Name = "txtPerYeniSifre";
            this.txtPerYeniSifre.Size = new System.Drawing.Size(152, 36);
            this.txtPerYeniSifre.TabIndex = 1;
            // 
            // txtPerSifre
            // 
            this.txtPerSifre.Location = new System.Drawing.Point(119, 115);
            this.txtPerSifre.Multiline = true;
            this.txtPerSifre.Name = "txtPerSifre";
            this.txtPerSifre.Size = new System.Drawing.Size(152, 35);
            this.txtPerSifre.TabIndex = 0;
            // 
            // groupBoxP2
            // 
            this.groupBoxP2.Controls.Add(this.btnEkle);
            this.groupBoxP2.Controls.Add(this.txtGorevID);
            this.groupBoxP2.Controls.Add(this.btnPerGuncelle);
            this.groupBoxP2.Controls.Add(this.label7);
            this.groupBoxP2.Controls.Add(this.label6);
            this.groupBoxP2.Controls.Add(this.label5);
            this.groupBoxP2.Controls.Add(this.label4);
            this.groupBoxP2.Controls.Add(this.txtPersonelID);
            this.groupBoxP2.Controls.Add(this.cbGorevPersonel);
            this.groupBoxP2.Controls.Add(this.txtPersonelSifreT);
            this.groupBoxP2.Controls.Add(this.txtPersonelSifre);
            this.groupBoxP2.Controls.Add(this.txtPersonelSoyad);
            this.groupBoxP2.Controls.Add(this.txtPersonelAd);
            this.groupBoxP2.Controls.Add(this.label3);
            this.groupBoxP2.Location = new System.Drawing.Point(368, 47);
            this.groupBoxP2.Name = "groupBoxP2";
            this.groupBoxP2.Size = new System.Drawing.Size(341, 320);
            this.groupBoxP2.TabIndex = 1;
            this.groupBoxP2.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(44, 262);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 44);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtGorevID
            // 
            this.txtGorevID.Location = new System.Drawing.Point(291, 201);
            this.txtGorevID.Multiline = true;
            this.txtGorevID.Name = "txtGorevID";
            this.txtGorevID.Size = new System.Drawing.Size(21, 28);
            this.txtGorevID.TabIndex = 19;
            // 
            // btnPerGuncelle
            // 
            this.btnPerGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnPerGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerGuncelle.Location = new System.Drawing.Point(161, 262);
            this.btnPerGuncelle.Name = "btnPerGuncelle";
            this.btnPerGuncelle.Size = new System.Drawing.Size(126, 44);
            this.btnPerGuncelle.TabIndex = 18;
            this.btnPerGuncelle.Text = "GÜNCELLE";
            this.btnPerGuncelle.UseVisualStyleBackColor = false;
            this.btnPerGuncelle.Click += new System.EventHandler(this.btnPerGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(18, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Şifre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre Tekrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Görevi:";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(291, 39);
            this.txtPersonelID.Multiline = true;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(16, 35);
            this.txtPersonelID.TabIndex = 12;
            // 
            // cbGorevPersonel
            // 
            this.cbGorevPersonel.FormattingEnabled = true;
            this.cbGorevPersonel.Location = new System.Drawing.Point(149, 205);
            this.cbGorevPersonel.Name = "cbGorevPersonel";
            this.cbGorevPersonel.Size = new System.Drawing.Size(138, 24);
            this.cbGorevPersonel.TabIndex = 7;
            this.cbGorevPersonel.SelectedIndexChanged += new System.EventHandler(this.cbGorevPersonel_SelectedIndexChanged);
            // 
            // txtPersonelSifreT
            // 
            this.txtPersonelSifreT.Location = new System.Drawing.Point(149, 164);
            this.txtPersonelSifreT.Multiline = true;
            this.txtPersonelSifreT.Name = "txtPersonelSifreT";
            this.txtPersonelSifreT.Size = new System.Drawing.Size(158, 35);
            this.txtPersonelSifreT.TabIndex = 11;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(149, 123);
            this.txtPersonelSifre.Multiline = true;
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(158, 35);
            this.txtPersonelSifre.TabIndex = 10;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(149, 82);
            this.txtPersonelSoyad.Multiline = true;
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(158, 35);
            this.txtPersonelSoyad.TabIndex = 9;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(149, 41);
            this.txtPersonelAd.Multiline = true;
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(138, 35);
            this.txtPersonelAd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ad:";
            // 
            // lwPersoneller
            // 
            this.lwPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwPersoneller.FullRowSelect = true;
            this.lwPersoneller.GridLines = true;
            this.lwPersoneller.Location = new System.Drawing.Point(174, 373);
            this.lwPersoneller.Name = "lwPersoneller";
            this.lwPersoneller.Size = new System.Drawing.Size(535, 132);
            this.lwPersoneller.TabIndex = 19;
            this.lwPersoneller.UseCompatibleStateImageBehavior = false;
            this.lwPersoneller.View = System.Windows.Forms.View.Details;
            this.lwPersoneller.SelectedIndexChanged += new System.EventHandler(this.lwPersoneller_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PersonelID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PersonselGorevID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gorevi";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adı";
            this.columnHeader4.Width = 195;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadı";
            this.columnHeader5.Width = 181;
            // 
            // btnMasalarCıkıs
            // 
            this.btnMasalarCıkıs.BackColor = System.Drawing.Color.Crimson;
            this.btnMasalarCıkıs.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasalarCıkıs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMasalarCıkıs.Location = new System.Drawing.Point(87, 454);
            this.btnMasalarCıkıs.Name = "btnMasalarCıkıs";
            this.btnMasalarCıkıs.Size = new System.Drawing.Size(81, 51);
            this.btnMasalarCıkıs.TabIndex = 21;
            this.btnMasalarCıkıs.Text = "ÇIKIŞ";
            this.btnMasalarCıkıs.UseVisualStyleBackColor = false;
            this.btnMasalarCıkıs.Click += new System.EventHandler(this.btnMasalarCıkıs_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGeri.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(22, 454);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(59, 51);
            this.btnGeri.TabIndex = 20;
            this.btnGeri.Text = "Geri DÖN";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // labelPersonel
            // 
            this.labelPersonel.AutoSize = true;
            this.labelPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonel.Location = new System.Drawing.Point(20, 19);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(0, 20);
            this.labelPersonel.TabIndex = 22;
            // 
            // frmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 513);
            this.Controls.Add(this.labelPersonel);
            this.Controls.Add(this.btnMasalarCıkıs);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lwPersoneller);
            this.Controls.Add(this.groupBoxP2);
            this.Controls.Add(this.groupBoxP1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelIslemleri";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.frmPersonelIslemleri_Load);
            this.groupBoxP1.ResumeLayout(false);
            this.groupBoxP1.PerformLayout();
            this.groupBoxP2.ResumeLayout(false);
            this.groupBoxP2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxP1;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.ComboBox cbPersoneller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerYeniSifre;
        private System.Windows.Forms.TextBox txtPerSifre;
        private System.Windows.Forms.GroupBox groupBoxP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.ComboBox cbGorevPersonel;
        private System.Windows.Forms.TextBox txtPersonelSifreT;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.ListView lwPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnPerGuncelle;
        private System.Windows.Forms.Button btnMasalarCıkıs;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label labelPersonel;
        private System.Windows.Forms.TextBox txtGorevID;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Button btnEkle;
    }
}