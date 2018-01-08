using HastahaneRandevuSistemi;
using HastahaneRandevuSistemi.Classes;
using HastahaneRandevuSistemi.Forms;
using System;
using System.Collections;
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
namespace HastahaneRandevuSistemi.Forms
{
    public partial class IstatistikForm : Form
    {
        public IstatistikForm()
        {
            InitializeComponent();
        }
        List<Personel> eskiListe = new List<Personel>();
        List<Doktor> eskiListe2 = new List<Doktor>();
        List<Hemsire> eskiListe3 = new List<Hemsire>();

        private void PersonellerimizForm_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Personel.xml";
            string path2 = Application.StartupPath + "\\Doktor.xml";
            string path3 = Application.StartupPath + "\\Hemsire.xml";

#region Doktor Sayısı
            var xml2 = new XmlSerializer(typeof(Doktor));

            XmlSerializer cevirici2 = new XmlSerializer(typeof(List<Doktor>));
            if (System.IO.File.Exists(path2))
            {
                FileStream gelenXML2 = System.IO.File.OpenRead(path2);
                eskiListe2 = (List<Doktor>)cevirici2.Deserialize(gelenXML2);
                foreach (var item2 in eskiListe2)
                {
                    ListViewItem li2 = new ListViewItem();


                    li2.Text = item2.Ad + "" + item2.Soyad;

                    li2.SubItems.Add(item2.Brans.ToString());


                    lstdoktorlarımız.Items.Add(li2);
                    lbldoktorsayisi.Text = lstdoktorlarımız.Items.Count.ToString();
                }
                gelenXML2.Close();

                #endregion
#region Personel sayısı
                var xml = new XmlSerializer(typeof(Personel));

                XmlSerializer cevirici = new XmlSerializer(typeof(List<Personel>));
                if (System.IO.File.Exists(path))
                {
                    FileStream gelenXML = System.IO.File.OpenRead(path);
                    eskiListe = (List<Personel>)cevirici.Deserialize(gelenXML);
                    foreach (var item in eskiListe)
                    {
                        ListViewItem li = new ListViewItem();


                        li.Text = item.Ad + "" + item.Soyad;

                        li.SubItems.Add(item.Gorev.ToString());


                        lstPersonellerimiz.Items.Add(li);
                        lblPersonelSayisi.Text = lstPersonellerimiz.Items.Count.ToString();
                    }
                    gelenXML.Close();
                }
                #endregion
#region Hemsire sayısı
                var xml3 = new XmlSerializer(typeof(Hemsire));

                XmlSerializer cevirici3 = new XmlSerializer(typeof(List<Hemsire>));
                if (System.IO.File.Exists(path3))
                {
                    FileStream gelenXML3 = System.IO.File.OpenRead(path3);
                    eskiListe3 = (List<Hemsire>)cevirici3.Deserialize(gelenXML3);
                    foreach (var item3 in eskiListe3)
                    {
                        ListViewItem li3 = new ListViewItem();


                        li3.Text = item3.Ad + "" + item3.Soyad;

                        li3.SubItems.Add(item3.Brans.ToString());


                        lstHemsirelerimiz.Items.Add(li3);
                        lblHemsireSayisi.Text = lstHemsirelerimiz.Items.Count.ToString();
                    }
                    gelenXML3.Close();
                }
#endregion
                int toplam=lstdoktorlarımız.Items.Count + lstHemsirelerimiz.Items.Count + lstPersonellerimiz.Items.Count;
                lblToplamCalisanSayisi.Text = toplam.ToString();
            }
        }
    }
}
