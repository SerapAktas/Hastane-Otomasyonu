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
using static HastahaneRandevuSistemi.Classes.Personel;
using static HastahaneRandevuSistemi.Person;

namespace HastahaneRandevuSistemi
{
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        public List<Personel> Personeller { get; set; } = new List<Personel>();

        //string path = Application.StartupPath + "\\Personel.xml";
        List<Personel> eskiListe = new List<Personel>();
        private void Personel_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(Cinsiyet)));
            cmbGorev.Items.AddRange(Enum.GetNames(typeof(Personel.Gorevler)));
            ListeyiDoldur();

      #region Personel listesi
           /* var xml = new XmlSerializer(typeof(Personel));

            XmlSerializer cevirici = new XmlSerializer(typeof(List<Personel>));
            if (System.IO.File.Exists(path))
            {
                FileStream gelenXML = System.IO.File.OpenRead(path);
                eskiListe = (List<Personel>)cevirici.Deserialize(gelenXML);
                foreach (var item in eskiListe)
                {

                    //  ListViewItem li = new ListViewItem();
                    lbPersonelListe.Items.Add(item.TCKN +" "+item.Ad+" "+item.Soyad+" "+item.Gorev);
                    
                  //  lbPersonelListe.Items.Add(item.Ad);
                    //lbPersonelListe.Items.Add(item.Soyad);

                    //lbPersonelListe.Items.Add(item.Gorev.ToString());


                    
                   
                }
                gelenXML.Close();
            }    */
            #endregion
        }
        private void ListeyiDoldur()
        {
            lbPersonelListe.Items.Clear();
            foreach (Personel item in Personeller)
            {
                lbPersonelListe.Items.Add(item);
            }
        }
        Personel seciliPersonel;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

            Personel yeniKisi = new Personel
            {
                TCKN = txtTCKN.Text,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                DogumTarihi = dtpDogumTarihi.Value,
                Maas = Convert.ToDecimal(nudMaas.Text),
                Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                Gorev = (Gorevler)Enum.Parse(typeof(Gorevler), cmbGorev.SelectedItem.ToString())
            };
            Personeller.Add(yeniKisi);
            ListeyiDoldur();
            FormuTemizle();
            MessageBox.Show("Kayıt Başarılı !");

           /* ListViewItem kayit = new ListViewItem(yeniKisi.TCKN);
            kayit.SubItems.Add(yeniKisi.Ad);
            kayit.SubItems.Add(yeniKisi.Soyad);
            kayit.SubItems.Add(yeniKisi.DogumTarihi.ToString());
            kayit.SubItems.Add(yeniKisi.Maas.ToString());
            kayit.SubItems.Add(yeniKisi.Cinsiyetler.ToString());
            kayit.SubItems.Add(yeniKisi.Gorev.ToString());
           // lstHastaRandevu.Items.Add(kayit);



            XmlSerializer cevirici = new XmlSerializer(typeof(List<Personel>));
            if (System.IO.File.Exists(path))
            {
                FileStream gelenXML = System.IO.File.OpenRead(path);
                eskiListe = (List<Personel>)cevirici.Deserialize(gelenXML);
                gelenXML.Close();
            }
            



            eskiListe.Add(yeniKisi);
            FileStream yazici = new FileStream(path, FileMode.Create);
            cevirici.Serialize(yazici, eskiListe);
            yazici.Close();
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

        private void lbPersonelListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPersonelListe.SelectedIndex == -1) return;        
            seciliPersonel = lbPersonelListe.SelectedItem as Personel;
            txtTCKN.Text = seciliPersonel.TCKN;
            txtAd.Text = seciliPersonel.Ad;
            txtSoyad.Text = seciliPersonel.Soyad;
            cmbCinsiyet.SelectedIndex = (int)seciliPersonel.Cinsiyetler;
            dtpDogumTarihi.Value = seciliPersonel.DogumTarihi;

          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbPersonelListe.SelectedItem == null)
            {
                MessageBox.Show("Silinecek öğe yok"); return;
            }
            seciliPersonel = lbPersonelListe.SelectedItem as Personel;

            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} {seciliPersonel.Soyad} adlı kişiyi silmek istiyor musunuz", "Kişi Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Personeller.Remove(seciliPersonel);
                ListeyiDoldur();
                FormuTemizle();
                MessageBox.Show($" Silme Başarılı !");
                seciliPersonel = null;

            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

            if (lbPersonelListe.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek için kişi seçiniz!"); return;
            }
            seciliPersonel = lbPersonelListe.SelectedItem as Personel;

            DialogResult cevap = MessageBox.Show($"{seciliPersonel.Ad} {seciliPersonel.Soyad} adlı kişiyi güncellemek istiyor musunuz", "Kişi Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                seciliPersonel = Personeller.Where(item => item.TCKN == seciliPersonel.TCKN).FirstOrDefault();
                seciliPersonel.Ad = txtAd.Text;
                seciliPersonel.Soyad = txtSoyad.Text;
                seciliPersonel.TCKN = txtTCKN.Text;
                seciliPersonel.DogumTarihi = dtpDogumTarihi.Value;
                seciliPersonel.Cinsiyetler = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());
                ListeyiDoldur();
                seciliPersonel = null;
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
            List<Personel> aranacak = Arama<Personel>.Ara(Personeller, txtArama.Text);
            ListeyiDoldur(aranacak);
        }

        private void ListeyiDoldur(List<Personel> aranacakListesi)
        {
            lbPersonelListe.Items.Clear();
            foreach (Personel item in aranacakListesi)
            {
                lbPersonelListe.Items.Add(item);
            }
        }
    }
}

