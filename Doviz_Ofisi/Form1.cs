using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolarAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolarAlis;

            string dolarSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarSatis;

            string euroAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroAlis;

            string euroSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = euroSatis;

            string sterlinAlis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            lblSterlinAlis.Text = sterlinAlis;

            string sterlinSatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            lblSterlinSatis.Text = sterlinSatis;
        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
        }

        private void btnSterlinAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblSterlinAlis.Text;
        }

        private void btnSterlinSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblSterlinSatis.Text;
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (txtKur.Text != "")
            {
                txtKalan.Clear();

                double kur, miktar, tutar;
                kur = Convert.ToDouble(txtKur.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = kur * miktar;
                txtTutar.Text = tutar.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kur Seçin");
            }
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");
        }

        private void btnSatisYap2_Click(object sender, EventArgs e)
        {
            if (txtKur.Text != "")
            {
                double kur = Convert.ToDouble(txtKur.Text);
                int miktar = Convert.ToInt16(txtMiktar.Text);
                int tutar = Convert.ToInt32(miktar / kur);

                txtTutar.Text = tutar.ToString();

                double kalan = miktar % kur;
                txtKalan.Text = kalan.ToString("0.##") + " TL";
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kur Seçin");
            }
        }

    }
}