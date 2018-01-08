namespace HastahaneRandevuSistemi
{
    partial class PersonelForm
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
            this.lbPersonelListe = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersonelListe
            // 
            this.lbPersonelListe.FormattingEnabled = true;
            this.lbPersonelListe.Location = new System.Drawing.Point(300, 105);
            this.lbPersonelListe.Name = "lbPersonelListe";
            this.lbPersonelListe.Size = new System.Drawing.Size(282, 264);
            this.lbPersonelListe.TabIndex = 38;
            this.lbPersonelListe.SelectedIndexChanged += new System.EventHandler(this.lbPersonelListe_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(300, 72);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(282, 20);
            this.txtArama.TabIndex = 37;
            this.txtArama.Text = "Arama...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(193, 331);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 38);
            this.btnGüncelle.TabIndex = 36;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(102, 331);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 38);
            this.btnSil.TabIndex = 35;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(11, 331);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 38);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbGorev
            // 
            this.cmbGorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(98, 252);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(170, 21);
            this.cmbGorev.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Maaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Görev";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(98, 216);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(170, 21);
            this.cmbCinsiyet.TabIndex = 29;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(98, 177);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtpDogumTarihi.TabIndex = 28;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 144);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtSoyad.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cinsiyet";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 108);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 20);
            this.txtAd.TabIndex = 25;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(98, 72);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(170, 20);
            this.txtTCKN.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "TCKN";
            // 
            // nudMaas
            // 
            this.nudMaas.Location = new System.Drawing.Point(98, 289);
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(170, 20);
            this.nudMaas.TabIndex = 39;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.nudMaas);
            this.Controls.Add(this.lbPersonelListe);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbGorev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelForm";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersonelListe;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbGorev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaas;
    }
}