using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralamaVeSatisOtomasyonu.Context;
using AracKiralamaVeSatisOtomasyonu.Models;

namespace AracKiralamaVeSatisOtomasyonu
{
    public partial class FRMMusteriIslemleri : Form
    {
        MyDbContext _db;
        public FRMMusteriIslemleri()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }
        private void Listele()
        {
            dgvMusteriler.DataSource = _db.Musteri
                .Select(
                m => new
                {
                    m.AdSoyad,
                    m.Telefon,
                    m.Email,
                    m.Adres,
                }).ToList();
        }
        private void Temizle()
        {
            txtAdSoyad.Text = txtTelefon.Text = txtEposta.Text = txtAdres.Text = string.Empty;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var musteri = new Musteri
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEposta.Text,
                Adres = txtAdres.Text,
            };
            _db.Musteri.Add(musteri);
            _db.SaveChanges();
            MessageBox.Show("Eklendi");
            Temizle();
            Listele();
        }
        private void FRMMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow != null)
            {
                int id = (int)(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                var musteri = _db.Musteri.Find(id);
                if (musteri != null)
                {
                    _db.Musteri.Remove(musteri);
                    _db.SaveChanges();
                    MessageBox.Show("Silindi");
                    Temizle();
                    Listele();
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow!=null)
            {
                int id = (int)(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                var musteri = _db.Musteri.Find(id);

                if (musteri != null)
                {
                    musteri.AdSoyad = txtAdSoyad.Text;
                    musteri.Telefon = txtTelefon.Text;
                    musteri.Email = txtEmail.Text;
                    musteri.Adres = txtAdres.Text;
                    _db.SaveChanges();
                    MessageBox.Show("Güncellendi");
                    Temizle();
                    Listele();
                }
            }
        }
    }
}
