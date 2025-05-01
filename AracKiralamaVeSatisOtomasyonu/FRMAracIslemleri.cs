using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralamaVeSatisOtomasyonu.Context;
using AracKiralamaVeSatisOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;

namespace AracKiralamaVeSatisOtomasyonu
{
    public partial class FRMAracIslemleri : Form
    {
       private readonly MyDbContext _db;
        public FRMAracIslemleri()
        {
            InitializeComponent();
            _db = new MyDbContext();
            Listele();
            SanzimanEkle();
            YakitTuruEkle();
            RenkEkle();
            DUrumEKle();
            MevcutDurumEkle();
            Birlestir();
            KategoriEkle();
        }
        private void Birlestir()
        {
            var kategoriAraclar = _db.Kategori.Include(k => k.Araclar).SelectMany(k => k.Araclar, (k, a) => new
            {
                a.Id,
                a.Marka,
                a.Model,
                a.Yil,
                a.Kilometre,
                a.YakitTuru,
                a.SanzimanTipi,
                a.Durum,
                a.MevcutDurum,
                a.KategoriId,
                a.Renk,

            }).ToList();
            dgvAraclar.DataSource = kategoriAraclar;
        }
        private void Listele()
        {
            var araclar = _db.Arac.Select(a => new
            {
                a.Id,
                a.Marka,
                a.Model,
                a.Yil,
                a.Kilometre,
                a.YakitTuru,
                a.SanzimanTipi,
                a.Durum,
                a.MevcutDurum,
                a.KategoriId,
                a.Renk
            }).ToList();
            dgvAraclar.DataSource = araclar;
        }
        private void Temizle()
        {
            txtMarka.Text = txtModel.Text = string.Empty;
            nudKm.Value = nudYil.Value = 0;
            cmbDurum.SelectedIndex = -1;
            cmbKategori.SelectedIndex = -1;
            cmbMevcutDurum.SelectedIndex = -1;
            cmbRenk.SelectedIndex = -1;
            cmbSanzimanTipi.SelectedIndex = -1;
            cmbYakitTuru.SelectedIndex = -1;
        }
        private bool GirdiDogrula()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text))
            {
                MessageBox.Show("Lütfen Aracın Markasını Giriniz!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Aracın Modelini Giriniz!");
                return false;
            }
            if (nudYil.Value == 0)
            {
                MessageBox.Show("Lütfen Yıl giriniz");
                return false;
            }
            if (nudKm.Value == 0)
            {
                MessageBox.Show("Lütfen Km bilgisi Giriniz!");
                return false;
            }
            if (cmbYakitTuru.SelectedItem == null)
            {
                MessageBox.Show("Yakıt türünüz Giriniz");
                return false;
            }
            if (cmbSanzimanTipi.SelectedItem == null)
            {
                MessageBox.Show("Şanzıman Türünü Seçiniz");
                return false;
            }
            if (cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Durum biligisi Seçiniz");
                return false;
            }
            if (cmbMevcutDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Mevcut Durumunu Seçiniz");
                return false;
            }
            if (cmbKategori.SelectedItem == null)
            {
                MessageBox.Show("Aracın Kategorisini Seçiniz");
                return false;
            }
            if (cmbRenk.SelectedItem == null)
            {
                MessageBox.Show("Aracın Rengini Seçiniz");
                return false;
            }
            return true;
        }
        private void SanzimanEkle()
        {
            List<string> sanzimanTuru = new List<string>
            {
                "Manuel",
                "Otomatik",
                "Yarı Otomatik",
            };
            cmbSanzimanTipi.DataSource = sanzimanTuru;
        }
        private void YakitTuruEkle()
        {
            List<string> yakitTuru = new()
            {
                "Benzin",
                "Dizel",
                "LPG",
                "Elektirik",
                "Hibrit",
            };
            cmbYakitTuru.DataSource = yakitTuru;
        }
        private void RenkEkle()
        {
            List<string> renk = new()
            {
                "Beyaz",
                "Siyah",
                "Gri",
                "Kırmızı",
                "Mavi",
                "Kahverengi",
            };
            cmbRenk.DataSource = renk;
        }
        private void DUrumEKle()
        {
            List<string> durum = new()
            {
                "Kiralık",
                "Satılık"
            };
            cmbDurum.DataSource = durum;
        }
        private void MevcutDurumEkle()
        {
            List<string> mevcutDurum = new()
            {
                "Kiralık",
                "Satılık",
                "Müsait"
            };
            cmbMevcutDurum.DataSource = mevcutDurum;
        }
        private void KategoriEkle()
        {
            var kategoriler = _db.Kategori.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriId";
            cmbKategori.SelectedIndex = -1;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GirdiDogrula()) return;

                var arac = new Arac()
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    Yil = Convert.ToInt32(nudYil.Text),
                    Kilometre = Convert.ToInt32(nudKm.Text),
                    YakitTuru = cmbYakitTuru.SelectedItem.ToString(),
                    SanzimanTipi = cmbSanzimanTipi.SelectedItem.ToString(),
                    Durum = cmbDurum.SelectedItem.ToString(),
                    MevcutDurum = cmbMevcutDurum.SelectedItem.ToString(),
                    KategoriId = (int)cmbKategori.SelectedValue,
                    Renk = cmbRenk.SelectedItem.ToString(),
                };
                _db.Arac.Add(arac);
                _db.SaveChanges();
                MessageBox.Show("Ekleme başarılı");
                Temizle();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Seçmek İstediğiniz Satırı Seçiniz");
                return;
            }
            var aracId = (int)dgvAraclar.SelectedRows[0].Cells["Id"].Value;
            var arac = _db.Arac.Find(aracId);

            if (arac != null)
            {
                _db.Arac.Remove(arac);
                _db.SaveChanges();
                MessageBox.Show("Başarıyla silindi");
                Listele();
            }
        }
        Arac secilenarac;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenarac.Marka = txtMarka.Text;
            secilenarac.Model = txtModel.Text;
            secilenarac.Yil = Convert.ToInt32(nudYil.Value);
            secilenarac.Kilometre = Convert.ToInt32(nudKm.Value);
            secilenarac.YakitTuru = cmbYakitTuru.SelectedItem.ToString();
            secilenarac.SanzimanTipi = cmbSanzimanTipi.SelectedItem.ToString();
            secilenarac.Durum = cmbDurum.SelectedItem.ToString();
            secilenarac.MevcutDurum = cmbMevcutDurum.ToString();
            secilenarac.KategoriId = (int)cmbKategori.SelectedValue;
            secilenarac.Renk = cmbRenk.SelectedItem.ToString();
            _db.SaveChanges();
            Listele();
            MessageBox.Show("Güncelledi");
        }
        private void dgvAraclar_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAraclar.SelectedRows.Count>0)
            {
                var aracId = (int)dgvAraclar.SelectedRows[0].Cells["Id"].Value;
                secilenarac = _db.Arac.Include(a => a.Kategori).FirstOrDefault(a => a.Id == aracId);

                if (secilenarac != null)
                {
                    txtMarka.Text= secilenarac.Marka;
                    txtModel.Text= secilenarac.Model;
                    nudYil.Value= secilenarac.Yil;
                    nudKm.Value = secilenarac.Kilometre;
                    cmbYakitTuru.SelectedItem = secilenarac.YakitTuru;
                    cmbSanzimanTipi.SelectedItem= secilenarac.SanzimanTipi;
                    cmbKategori.SelectedValue= secilenarac.KategoriId;
                    cmbDurum.SelectedItem= secilenarac.Durum;
                    cmbMevcutDurum.SelectedItem = secilenarac.MevcutDurum;
                    cmbRenk.SelectedItem= secilenarac.Renk;
                }
            }
        }
    }
}
