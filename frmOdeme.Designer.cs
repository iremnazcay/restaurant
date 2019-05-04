namespace restaurant
{
    partial class frmOdeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdeme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbindirim = new System.Windows.Forms.Label();
            this.lbKDV = new System.Windows.Forms.Label();
            this.lbFiyat = new System.Windows.Forms.Label();
            this.lbAraToplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIndirimUygula = new System.Windows.Forms.TextBox();
            this.chIndirim = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbKrediKartı = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lvUrunlerOdeme = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasalarCıkıs = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lbAdisyonID = new System.Windows.Forms.Label();
            this.btnHesapKapa = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbindirim);
            this.groupBox1.Controls.Add(this.lbKDV);
            this.groupBox1.Controls.Add(this.lbFiyat);
            this.groupBox1.Controls.Add(this.lbAraToplam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Bilgileri";
            // 
            // lbindirim
            // 
            this.lbindirim.AutoSize = true;
            this.lbindirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbindirim.Location = new System.Drawing.Point(156, 33);
            this.lbindirim.Name = "lbindirim";
            this.lbindirim.Size = new System.Drawing.Size(21, 24);
            this.lbindirim.TabIndex = 11;
            this.lbindirim.Text = "0";
            this.lbindirim.TextChanged += new System.EventHandler(this.lbIndirim_TextChanged);
            // 
            // lbKDV
            // 
            this.lbKDV.AutoSize = true;
            this.lbKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKDV.Location = new System.Drawing.Point(156, 53);
            this.lbKDV.Name = "lbKDV";
            this.lbKDV.Size = new System.Drawing.Size(21, 24);
            this.lbKDV.TabIndex = 10;
            this.lbKDV.Text = "0";
            // 
            // lbFiyat
            // 
            this.lbFiyat.AutoSize = true;
            this.lbFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbFiyat.Location = new System.Drawing.Point(156, 76);
            this.lbFiyat.Name = "lbFiyat";
            this.lbFiyat.Size = new System.Drawing.Size(21, 24);
            this.lbFiyat.TabIndex = 9;
            this.lbFiyat.Text = "0";
            // 
            // lbAraToplam
            // 
            this.lbAraToplam.AutoSize = true;
            this.lbAraToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAraToplam.Location = new System.Drawing.Point(156, 101);
            this.lbAraToplam.Name = "lbAraToplam";
            this.lbAraToplam.Size = new System.Drawing.Size(21, 24);
            this.lbAraToplam.TabIndex = 8;
            this.lbAraToplam.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(229, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(229, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(229, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(229, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ara Toplam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "İndirim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIndirimUygula);
            this.groupBox2.Controls.Add(this.chIndirim);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(473, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Özel İndirim";
            // 
            // txtIndirimUygula
            // 
            this.txtIndirimUygula.Location = new System.Drawing.Point(189, 38);
            this.txtIndirimUygula.Multiline = true;
            this.txtIndirimUygula.Name = "txtIndirimUygula";
            this.txtIndirimUygula.Size = new System.Drawing.Size(164, 30);
            this.txtIndirimUygula.TabIndex = 15;
            this.txtIndirimUygula.TextChanged += new System.EventHandler(this.txtIndirimUygula_TextChanged);
            // 
            // chIndirim
            // 
            this.chIndirim.AutoSize = true;
            this.chIndirim.Location = new System.Drawing.Point(37, 40);
            this.chIndirim.Name = "chIndirim";
            this.chIndirim.Size = new System.Drawing.Size(136, 22);
            this.chIndirim.TabIndex = 14;
            this.chIndirim.Text = "İndirim Uygula";
            this.chIndirim.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbKrediKartı);
            this.groupBox3.Controls.Add(this.rbNakit);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(322, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Türü";
            // 
            // rbKrediKartı
            // 
            this.rbKrediKartı.AutoSize = true;
            this.rbKrediKartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKartı.Location = new System.Drawing.Point(40, 86);
            this.rbKrediKartı.Name = "rbKrediKartı";
            this.rbKrediKartı.Size = new System.Drawing.Size(127, 28);
            this.rbKrediKartı.TabIndex = 1;
            this.rbKrediKartı.TabStop = true;
            this.rbKrediKartı.Text = "Kredi Kartı";
            this.rbKrediKartı.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(40, 49);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(77, 28);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // lvUrunlerOdeme
            // 
            this.lvUrunlerOdeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvUrunlerOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunlerOdeme.FullRowSelect = true;
            this.lvUrunlerOdeme.GridLines = true;
            this.lvUrunlerOdeme.Location = new System.Drawing.Point(12, 56);
            this.lvUrunlerOdeme.Name = "lvUrunlerOdeme";
            this.lvUrunlerOdeme.Size = new System.Drawing.Size(434, 154);
            this.lvUrunlerOdeme.TabIndex = 2;
            this.lvUrunlerOdeme.UseCompatibleStateImageBehavior = false;
            this.lvUrunlerOdeme.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Urun Adi";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adet";
            this.columnHeader8.Width = 72;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "UrunID";
            this.columnHeader9.Width = 74;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Fiyat";
            this.columnHeader10.Width = 76;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "SatışID";
            this.columnHeader11.Width = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Siparişler";
            // 
            // btnMasalarCıkıs
            // 
            this.btnMasalarCıkıs.BackColor = System.Drawing.Color.Crimson;
            this.btnMasalarCıkıs.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasalarCıkıs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMasalarCıkıs.Location = new System.Drawing.Point(77, 393);
            this.btnMasalarCıkıs.Name = "btnMasalarCıkıs";
            this.btnMasalarCıkıs.Size = new System.Drawing.Size(81, 51);
            this.btnMasalarCıkıs.TabIndex = 13;
            this.btnMasalarCıkıs.Text = "ÇIKIŞ";
            this.btnMasalarCıkıs.UseVisualStyleBackColor = false;
            this.btnMasalarCıkıs.Click += new System.EventHandler(this.btnMasalarCıkıs_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGeri.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(12, 393);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(59, 51);
            this.btnGeri.TabIndex = 12;
            this.btnGeri.Text = "Geri DÖN";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lbAdisyonID
            // 
            this.lbAdisyonID.AutoSize = true;
            this.lbAdisyonID.ForeColor = System.Drawing.Color.DarkRed;
            this.lbAdisyonID.Location = new System.Drawing.Point(137, 20);
            this.lbAdisyonID.Name = "lbAdisyonID";
            this.lbAdisyonID.Size = new System.Drawing.Size(21, 17);
            this.lbAdisyonID.TabIndex = 14;
            this.lbAdisyonID.Text = "ID";
            // 
            // btnHesapKapa
            // 
            this.btnHesapKapa.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHesapKapa.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapKapa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHesapKapa.Location = new System.Drawing.Point(655, 370);
            this.btnHesapKapa.Name = "btnHesapKapa";
            this.btnHesapKapa.Size = new System.Drawing.Size(212, 57);
            this.btnHesapKapa.TabIndex = 15;
            this.btnHesapKapa.Text = "Hesap Kapat";
            this.btnHesapKapa.UseVisualStyleBackColor = false;
            this.btnHesapKapa.Click += new System.EventHandler(this.btnHesapKapa_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHesapOzeti.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapOzeti.ForeColor = System.Drawing.Color.Black;
            this.btnHesapOzeti.Location = new System.Drawing.Point(655, 309);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(212, 51);
            this.btnHesapOzeti.TabIndex = 16;
            this.btnHesapOzeti.Text = "Hesap Özeti";
            this.btnHesapOzeti.UseVisualStyleBackColor = false;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 458);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.btnHesapKapa);
            this.Controls.Add(this.lbAdisyonID);
            this.Controls.Add(this.btnMasalarCıkıs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lvUrunlerOdeme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmOdeme";
            this.Text = "Ödeme ";
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbindirim;
        private System.Windows.Forms.Label lbKDV;
        private System.Windows.Forms.Label lbFiyat;
        private System.Windows.Forms.Label lbAraToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbKrediKartı;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.ListView lvUrunlerOdeme;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chIndirim;
        private System.Windows.Forms.Button btnMasalarCıkıs;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtIndirimUygula;
        private System.Windows.Forms.Label lbAdisyonID;
        private System.Windows.Forms.Button btnHesapKapa;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}