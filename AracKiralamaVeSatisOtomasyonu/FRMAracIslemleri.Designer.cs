namespace AracKiralamaVeSatisOtomasyonu
{
    partial class FRMAracIslemleri
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
            label2 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            nudYil = new NumericUpDown();
            nudKm = new NumericUpDown();
            cmbRenk = new ComboBox();
            cmbDurum = new ComboBox();
            cmbYakitTuru = new ComboBox();
            cmbSanzimanTipi = new ComboBox();
            cmbMevcutDurum = new ComboBox();
            cmbKategori = new ComboBox();
            dgvAraclar = new DataGridView();
            btnKiraRaporu = new Button();
            txtSatisRaporu = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 56);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Model";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(111, 14);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(592, 27);
            txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(111, 53);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(592, 27);
            txtModel.TabIndex = 3;
            // 
            // nudYil
            // 
            nudYil.Location = new Point(111, 97);
            nudYil.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudYil.Name = "nudYil";
            nudYil.Size = new Size(592, 27);
            nudYil.TabIndex = 4;
            // 
            // nudKm
            // 
            nudKm.Location = new Point(111, 137);
            nudKm.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudKm.Name = "nudKm";
            nudKm.Size = new Size(592, 27);
            nudKm.TabIndex = 5;
            // 
            // cmbRenk
            // 
            cmbRenk.FormattingEnabled = true;
            cmbRenk.Location = new Point(111, 389);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(592, 28);
            cmbRenk.TabIndex = 6;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(111, 260);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(592, 28);
            cmbDurum.TabIndex = 7;
            // 
            // cmbYakitTuru
            // 
            cmbYakitTuru.FormattingEnabled = true;
            cmbYakitTuru.Location = new Point(111, 178);
            cmbYakitTuru.Name = "cmbYakitTuru";
            cmbYakitTuru.Size = new Size(592, 28);
            cmbYakitTuru.TabIndex = 8;
            // 
            // cmbSanzimanTipi
            // 
            cmbSanzimanTipi.FormattingEnabled = true;
            cmbSanzimanTipi.Location = new Point(111, 216);
            cmbSanzimanTipi.Name = "cmbSanzimanTipi";
            cmbSanzimanTipi.Size = new Size(592, 28);
            cmbSanzimanTipi.TabIndex = 9;
            // 
            // cmbMevcutDurum
            // 
            cmbMevcutDurum.FormattingEnabled = true;
            cmbMevcutDurum.Location = new Point(111, 303);
            cmbMevcutDurum.Name = "cmbMevcutDurum";
            cmbMevcutDurum.Size = new Size(592, 28);
            cmbMevcutDurum.TabIndex = 10;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(111, 346);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(592, 28);
            cmbKategori.TabIndex = 11;
            // 
            // dgvAraclar
            // 
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(8, 494);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.Size = new Size(780, 188);
            dgvAraclar.TabIndex = 12;
            dgvAraclar.SelectionChanged += dgvAraclar_SelectionChanged;
            // 
            // btnKiraRaporu
            // 
            btnKiraRaporu.Location = new Point(557, 459);
            btnKiraRaporu.Name = "btnKiraRaporu";
            btnKiraRaporu.Size = new Size(146, 29);
            btnKiraRaporu.TabIndex = 13;
            btnKiraRaporu.Text = "Kira Raporu";
            btnKiraRaporu.UseVisualStyleBackColor = true;
            // 
            // txtSatisRaporu
            // 
            txtSatisRaporu.Location = new Point(395, 459);
            txtSatisRaporu.Name = "txtSatisRaporu";
            txtSatisRaporu.Size = new Size(146, 29);
            txtSatisRaporu.TabIndex = 14;
            txtSatisRaporu.Text = "Satış Raporu";
            txtSatisRaporu.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(236, 459);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(121, 459);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 16;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(8, 459);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 17;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 104);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 0;
            label3.Text = "Yıl";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 144);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 1;
            label4.Text = "Kilometre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 186);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 0;
            label5.Text = "Yakıt Türü";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 224);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 1;
            label6.Text = "Şanzıman Tipi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 268);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "Durum";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 311);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 1;
            label8.Text = "Mevcut Durum";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 354);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 0;
            label9.Text = "Kategori";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(55, 397);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 1;
            label10.Text = "Renk";
            // 
            // FRMAracIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 694);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtSatisRaporu);
            Controls.Add(btnKiraRaporu);
            Controls.Add(dgvAraclar);
            Controls.Add(cmbKategori);
            Controls.Add(cmbMevcutDurum);
            Controls.Add(cmbSanzimanTipi);
            Controls.Add(cmbYakitTuru);
            Controls.Add(cmbDurum);
            Controls.Add(cmbRenk);
            Controls.Add(nudKm);
            Controls.Add(nudYil);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMAracIslemleri";
            Text = "FRMAracIslemleri";
            ((System.ComponentModel.ISupportInitialize)nudYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMarka;
        private TextBox txtModel;
        private NumericUpDown nudYil;
        private NumericUpDown nudKm;
        private ComboBox cmbRenk;
        private ComboBox cmbDurum;
        private ComboBox cmbYakitTuru;
        private ComboBox cmbSanzimanTipi;
        private ComboBox cmbMevcutDurum;
        private ComboBox cmbKategori;
        private DataGridView dgvAraclar;
        private Button btnKiraRaporu;
        private Button txtSatisRaporu;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}