using HastahaneRandevuSistemi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static HastahaneRandevuSistemi.Classes.RandevuBilgileri;
using static HastahaneRandevuSistemi.Person;

namespace HastahaneRandevuSistemi
{
    public partial class HemsireForm : Form
    {
        public HemsireForm()
        {
            InitializeComponent();
        }
        List<Hemsire> eskiListe3 = new List<Hemsire>();
        public List<Hemsire> Hemsireler{ get; set; } = new List<Hemsire>();

       // string path3 = Application.StartupPath + "\\Hemsire.xml";

        public static List<Hemsire> hemsireler = new List<Hemsire>();
        private void HemsireForm_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbBrans.Items.AddRange(Enum.GetNames(typeof(HBranslar)));
            ListeyiDoldur();
        }
        private void ListeyiDoldur()
        {
            lbHemsire.Items.Clear();
            foreach (Hemsire item in hemsireler)
            {
                lbHemsire.Items.Add(item);
            }
        }
        Hemsire seciliHemsire;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Hemsire yeniHemsire = new Hemsire
                {
                    TCKN = txtTCKN.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Maas = Convert.ToDecimal(nudMaas.Text),
                    Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                    Brans = (HBranslar)Enum.Parse(typeof(HBranslar), cmbBrans.SelectedItem.ToString())

                };
                hemsireler.Add(yeniHemsire);
                ListeyiDoldur();
                FormuTemizle();
                MessageBox.Show("Kayıt Başarılı!");

                /*XmlSerializer cevirici3 = new XmlSerializer(typeof(List<Hemsire>));
                if (System.IO.File.Exists(path3))
                {
                    FileStream gelenXML3 = System.IO.File.OpenRead(path3);
                    eskiListe3 = (List<Hemsire>)cevirici3.Deserialize(gelenXML3);
                    gelenXML3.Close();
                }

                eskiListe3.Add(yeniHemsire);
                FileStream yazici3 = new FileStream(path3, FileMode.Create);
                cevirici3.Serialize(yazici3, eskiListe3);
                yazici3.Close();
                      */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is NumericUpDown)
                    item.Text = string.Empty;
            }
        }

        
        private void lbHemsire_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHemsire.SelectedIndex == -1) return;
            seciliHemsire = lbHemsire.SelectedItem as Hemsire;
            txtTCKN.Text = seciliHemsire.TCKN;
            txtAd.Text = seciliHemsire.Ad;
            txtSoyad.Text = seciliHemsire.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliHemsire.Cinsiyetler;
            dtpDogumTarihi.Value = seciliHemsire.DogumTarihi;
            cmbBrans.SelectedIndex = (int)seciliHemsire.Brans;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbHemsire.SelectedItem == null)
            {
                MessageBox.Show("Silinecek öğe yok"); return;
            }
            seciliHemsire = lbHemsire.SelectedItem as Hemsire;

            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} {seciliHemsire.Soyad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                hemsireler.Remove(seciliHemsire);
                ListeyiDoldur();
                FormuTemizle();
                MessageBox.Show($"{seciliHemsire.Ad} {seciliHemsire.Soyad} adlı kişi silindi");
                seciliHemsire = null;
                
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

            if (lbHemsire.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek için kişi seçiniz!"); return;
            }
            seciliHemsire = lbHemsire.SelectedItem as Hemsire;

            DialogResult cevap = MessageBox.Show($"{seciliHemsire.Ad} {seciliHemsire.Soyad} adlı kişiyi silmek istiyor musunuz", "Kişi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                seciliHemsire = hemsireler.Where(item => item.TCKN == seciliHemsire.TCKN).FirstOrDefault();
                seciliHemsire.Ad = txtAd.Text;
                seciliHemsire.Soyad = txtSoyad.Text;
                seciliHemsire.TCKN = txtTCKN.Text;
                seciliHemsire.DogumTarihi = dtpDogumTarihi.Value;
                seciliHemsire.Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());
                ListeyiDoldur();
                seciliHemsire = null;
                MessageBox.Show("Güncelleme Başarılı");
                FormuTemizle();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            List<Hemsire> aranacak = Arama<Hemsire>.Ara( Hemsireler, txtArama.Text);
            ListeyiDoldur(aranacak);
        }

        private void ListeyiDoldur(List<Hemsire> aranacakListesi)
        {
            lbHemsire.Items.Clear();

            foreach (Hemsire item in aranacakListesi)
            {
                lbHemsire.Items.Add(item);
            }
        }
    }
}
