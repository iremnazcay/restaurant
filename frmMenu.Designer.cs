namespace restaurant
{
    partial class frmMenu
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
            this.btnMasa = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnPersonelIslem = new System.Windows.Forms.Button();
            this.btnMutfak = new System.Windows.Forms.Button();
            this.btnMenuCıkıs = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasa
            // 
            this.btnMasa.BackColor = System.Drawing.Color.Beige;
            this.btnMasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa.Location = new System.Drawing.Point(89, 56);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(174, 96);
            this.btnMasa.TabIndex = 0;
            this.btnMasa.Text = "Masalar";
            this.btnMasa.UseVisualStyleBackColor = false;
            this.btnMasa.Click += new System.EventHandler(this.btnMasa_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackColor = System.Drawing.Color.Beige;
            this.btnRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.Location = new System.Drawing.Point(269, 56);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(244, 96);
            this.btnRezervasyon.TabIndex = 1;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.UseVisualStyleBackColor = false;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnPersonelIslem
            // 
            this.btnPersonelIslem.BackColor = System.Drawing.Color.Beige;
            this.btnPersonelIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslem.Location = new System.Drawing.Point(89, 285);
            this.btnPersonelIslem.Name = "btnPersonelIslem";
            this.btnPersonelIslem.Size = new System.Drawing.Size(243, 95);
            this.btnPersonelIslem.TabIndex = 4;
            this.btnPersonelIslem.Text = "Personel İşlemleri";
            this.btnPersonelIslem.UseVisualStyleBackColor = false;
            this.btnPersonelIslem.Click += new System.EventHandler(this.btnPersonelIslem_Click);
            // 
            // btnMutfak
            // 
            this.btnMutfak.BackColor = System.Drawing.Color.Beige;
            this.btnMutfak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMutfak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMutfak.Location = new System.Drawing.Point(302, 168);
            this.btnMutfak.Name = "btnMutfak";
            this.btnMutfak.Size = new System.Drawing.Size(211, 97);
            this.btnMutfak.TabIndex = 5;
            this.btnMutfak.Text = "Ürünler";
            this.btnMutfak.UseVisualStyleBackColor = false;
            this.btnMutfak.Click += new System.EventHandler(this.btnMutfak_Click);
            // 
            // btnMenuCıkıs
            // 
            this.btnMenuCıkıs.BackColor = System.Drawing.Color.Beige;
            this.btnMenuCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuCıkıs.Location = new System.Drawing.Point(338, 284);
            this.btnMenuCıkıs.Name = "btnMenuCıkıs";
            this.btnMenuCıkıs.Size = new System.Drawing.Size(175, 96);
            this.btnMenuCıkıs.TabIndex = 7;
            this.btnMenuCıkıs.Text = "Çıkış";
            this.btnMenuCıkıs.UseVisualStyleBackColor = false;
            this.btnMenuCıkıs.Click += new System.EventHandler(this.btnMenuCıkıs_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackColor = System.Drawing.Color.Beige;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.Location = new System.Drawing.Point(89, 167);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(207, 98);
            this.btnMusteriler.TabIndex = 8;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = false;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 438);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnMenuCıkıs);
            this.Controls.Add(this.btnMutfak);
            this.Controls.Add(this.btnPersonelIslem);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMasa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnPersonelIslem;
        private System.Windows.Forms.Button btnMutfak;
        private System.Windows.Forms.Button btnMenuCıkıs;
        private System.Windows.Forms.Button btnMusteriler;
    }
}