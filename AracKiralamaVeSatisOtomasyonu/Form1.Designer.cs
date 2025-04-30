namespace AracKiralamaVeSatisOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMusteriIslemi = new Button();
            btnAracIslemleri = new Button();
            btnKiralamaIslemi = new Button();
            btnSatisIslemi = new Button();
            SuspendLayout();
            // 
            // btnMusteriIslemi
            // 
            btnMusteriIslemi.Location = new Point(74, 149);
            btnMusteriIslemi.Name = "btnMusteriIslemi";
            btnMusteriIslemi.Size = new Size(172, 56);
            btnMusteriIslemi.TabIndex = 0;
            btnMusteriIslemi.Text = "Müşteri İşlemleri";
            btnMusteriIslemi.UseVisualStyleBackColor = true;
            btnMusteriIslemi.Click += btnMusteriIslemi_Click;
            // 
            // btnAracIslemleri
            // 
            btnAracIslemleri.Location = new Point(74, 65);
            btnAracIslemleri.Name = "btnAracIslemleri";
            btnAracIslemleri.Size = new Size(172, 56);
            btnAracIslemleri.TabIndex = 1;
            btnAracIslemleri.Text = "Araç İşlemleri";
            btnAracIslemleri.UseVisualStyleBackColor = true;
            btnAracIslemleri.Click += btnAracIslemleri_Click_1;
            // 
            // btnKiralamaIslemi
            // 
            btnKiralamaIslemi.Location = new Point(74, 313);
            btnKiralamaIslemi.Name = "btnKiralamaIslemi";
            btnKiralamaIslemi.Size = new Size(172, 56);
            btnKiralamaIslemi.TabIndex = 2;
            btnKiralamaIslemi.Text = "Kiralama İşlemi";
            btnKiralamaIslemi.UseVisualStyleBackColor = true;
            // 
            // btnSatisIslemi
            // 
            btnSatisIslemi.Location = new Point(74, 230);
            btnSatisIslemi.Name = "btnSatisIslemi";
            btnSatisIslemi.Size = new Size(172, 56);
            btnSatisIslemi.TabIndex = 3;
            btnSatisIslemi.Text = "Satış İşlemi";
            btnSatisIslemi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 450);
            Controls.Add(btnSatisIslemi);
            Controls.Add(btnKiralamaIslemi);
            Controls.Add(btnAracIslemleri);
            Controls.Add(btnMusteriIslemi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMusteriIslemi;
        private Button btnAracIslemleri;
        private Button btnKiralamaIslemi;
        private Button btnSatisIslemi;
    }
}
