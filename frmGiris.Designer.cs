namespace restaurant
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKullanıcıAd = new System.Windows.Forms.ComboBox();
            this.txtKullanıcıSifre = new System.Windows.Forms.TextBox();
            this.btnKullanıcıGiris = new System.Windows.Forms.Button();
            this.btnKullanıcıCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(158, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // cbKullanıcıAd
            // 
            this.cbKullanıcıAd.FormattingEnabled = true;
            this.cbKullanıcıAd.Location = new System.Drawing.Point(230, 133);
            this.cbKullanıcıAd.Name = "cbKullanıcıAd";
            this.cbKullanıcıAd.Size = new System.Drawing.Size(198, 24);
            this.cbKullanıcıAd.TabIndex = 2;
            this.cbKullanıcıAd.SelectedIndexChanged += new System.EventHandler(this.cbKullanıcıAd_SelectedIndexChanged);
            // 
            // txtKullanıcıSifre
            // 
            this.txtKullanıcıSifre.Location = new System.Drawing.Point(228, 171);
            this.txtKullanıcıSifre.Multiline = true;
            this.txtKullanıcıSifre.Name = "txtKullanıcıSifre";
            this.txtKullanıcıSifre.PasswordChar = '*';
            this.txtKullanıcıSifre.Size = new System.Drawing.Size(200, 33);
            this.txtKullanıcıSifre.TabIndex = 3;
            // 
            // btnKullanıcıGiris
            // 
            this.btnKullanıcıGiris.BackColor = System.Drawing.SystemColors.Info;
            this.btnKullanıcıGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıGiris.Location = new System.Drawing.Point(228, 230);
            this.btnKullanıcıGiris.Name = "btnKullanıcıGiris";
            this.btnKullanıcıGiris.Size = new System.Drawing.Size(97, 42);
            this.btnKullanıcıGiris.TabIndex = 4;
            this.btnKullanıcıGiris.Text = "Giris";
            this.btnKullanıcıGiris.UseVisualStyleBackColor = false;
            this.btnKullanıcıGiris.Click += new System.EventHandler(this.btnKullanıcıGiris_Click);
            // 
            // btnKullanıcıCikis
            // 
            this.btnKullanıcıCikis.BackColor = System.Drawing.SystemColors.Info;
            this.btnKullanıcıCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıCikis.Location = new System.Drawing.Point(331, 230);
            this.btnKullanıcıCikis.Name = "btnKullanıcıCikis";
            this.btnKullanıcıCikis.Size = new System.Drawing.Size(97, 42);
            this.btnKullanıcıCikis.TabIndex = 4;
            this.btnKullanıcıCikis.Text = "Çıkış";
            this.btnKullanıcıCikis.UseVisualStyleBackColor = false;
            this.btnKullanıcıCikis.Click += new System.EventHandler(this.btnKullanıcıCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Restaurant";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKullanıcıCikis);
            this.Controls.Add(this.btnKullanıcıGiris);
            this.Controls.Add(this.txtKullanıcıSifre);
            this.Controls.Add(this.cbKullanıcıAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKullanıcıAd;
        private System.Windows.Forms.TextBox txtKullanıcıSifre;
        private System.Windows.Forms.Button btnKullanıcıGiris;
        private System.Windows.Forms.Button btnKullanıcıCikis;
        private System.Windows.Forms.Label label3;
    }
}

