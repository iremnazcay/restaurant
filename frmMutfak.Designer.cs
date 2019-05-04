namespace restaurant
{
    partial class frmMutfak
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
            this.lwUrunlerGoster = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMusteriCikis = new System.Windows.Forms.Button();
            this.btnMusteriGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwUrunlerGoster
            // 
            this.lwUrunlerGoster.BackColor = System.Drawing.SystemColors.Info;
            this.lwUrunlerGoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwUrunlerGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwUrunlerGoster.FullRowSelect = true;
            this.lwUrunlerGoster.GridLines = true;
            this.lwUrunlerGoster.Location = new System.Drawing.Point(28, 44);
            this.lwUrunlerGoster.Name = "lwUrunlerGoster";
            this.lwUrunlerGoster.Size = new System.Drawing.Size(820, 327);
            this.lwUrunlerGoster.TabIndex = 11;
            this.lwUrunlerGoster.UseCompatibleStateImageBehavior = false;
            this.lwUrunlerGoster.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun ID";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KategoriID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün adı";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 208;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            this.columnHeader5.Width = 98;
            // 
            // btnMusteriCikis
            // 
            this.btnMusteriCikis.BackColor = System.Drawing.Color.Crimson;
            this.btnMusteriCikis.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusteriCikis.Location = new System.Drawing.Point(82, 411);
            this.btnMusteriCikis.Name = "btnMusteriCikis";
            this.btnMusteriCikis.Size = new System.Drawing.Size(81, 51);
            this.btnMusteriCikis.TabIndex = 18;
            this.btnMusteriCikis.Text = "ÇIKIŞ";
            this.btnMusteriCikis.UseVisualStyleBackColor = false;
            this.btnMusteriCikis.Click += new System.EventHandler(this.btnMusteriCikis_Click);
            // 
            // btnMusteriGeriDon
            // 
            this.btnMusteriGeriDon.BackColor = System.Drawing.Color.GreenYellow;
            this.btnMusteriGeriDon.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusteriGeriDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMusteriGeriDon.Location = new System.Drawing.Point(17, 411);
            this.btnMusteriGeriDon.Name = "btnMusteriGeriDon";
            this.btnMusteriGeriDon.Size = new System.Drawing.Size(59, 51);
            this.btnMusteriGeriDon.TabIndex = 17;
            this.btnMusteriGeriDon.Text = "Geri DÖN";
            this.btnMusteriGeriDon.UseVisualStyleBackColor = false;
            this.btnMusteriGeriDon.Click += new System.EventHandler(this.btnMusteriGeriDon_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 474);
            this.Controls.Add(this.btnMusteriCikis);
            this.Controls.Add(this.btnMusteriGeriDon);
            this.Controls.Add(this.lwUrunlerGoster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMutfak";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwUrunlerGoster;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnMusteriCikis;
        private System.Windows.Forms.Button btnMusteriGeriDon;
    }
}