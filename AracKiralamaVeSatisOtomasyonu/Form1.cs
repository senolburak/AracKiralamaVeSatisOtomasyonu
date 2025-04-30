namespace AracKiralamaVeSatisOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriIslemi_Click(object sender, EventArgs e)
        {
            FRMMusteriIslemleri fRMMusteriIslemleri = new FRMMusteriIslemleri();
            fRMMusteriIslemleri.ShowDialog();
        }

        private void btnAracIslemleri_Click_1(object sender, EventArgs e)
        {

        }
    }
}
