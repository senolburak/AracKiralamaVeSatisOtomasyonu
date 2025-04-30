namespace AracKiralamaVeSatisOtomasyonu
{
    partial class FRMMusteriIslemleri
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
            label1 = new Label();
            label3 = new Label();
            txtEmail = new Label();
            label5 = new Label();
            dgvMusteriler = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 64);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(36, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(58, 20);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "E-Posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 148);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Adres";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(12, 247);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(544, 207);
            dgvMusteriler.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(285, 212);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(152, 212);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(21, 212);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(100, 17);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 16;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(100, 61);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 17;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(100, 103);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 16;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(100, 145);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 17;
            // 
            // FRMMusteriIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 462);
            Controls.Add(txtAdres);
            Controls.Add(txtEposta);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(dgvMusteriler);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FRMMusteriIslemleri";
            Text = "FRMMusteriIslemleri";
            Load += FRMMusteriIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtEmail;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dgvMusteriler;
        private Button button1;
        private Button button2;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtEposta;
        private TextBox txtAdres;
    }
}