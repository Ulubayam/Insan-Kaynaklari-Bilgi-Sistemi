using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERİODEV2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
         
        private void btnİsyeriKaydet_Click(object sender, EventArgs e)
        {
            Sirket sirket = new Sirket();
            sirket.ad = txtIsyeriadi.Text;
            sirket.telefon =Convert.ToInt32(txtIsyeriTelefon.Text);
            sirket.fax= Convert.ToInt32(txtFaks.Text);
            sirket.ePosta = txtIsyeriEposta.Text;
            sirket.adres = txtİsyeriAdres.Text;
            MessageBox.Show(sirket.sirketNo.ToString()+"Nolu Şirketiniz Oluşturuldu");
            txtIverecek.Text = sirket.sirketNo.ToString();
            Form1.hashIsyeri.Add(sirket.sirketNo, sirket);
            

            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Sirket tmpSirket = new Sirket();
            tmpSirket=(Sirket)(Form1.hashIsyeri.Get(Convert.ToInt32(txtIverecek.Text)));
            tmpSirket.isilani  = new IsIlani();
            tmpSirket.isilani.arananOzellik = txtArananOzellik.Text;
            tmpSirket.isilani.isTanimi = txtIsTanimi.Text;
            
            tmpSirket.IsIlaniOlustur(tmpSirket.isilani);
            Form1.hashIsyeri.RemoveSirket(Convert.ToInt32(txtIverecek.Text));
            Form1.hashIsyeri.Add(tmpSirket.sirketNo, tmpSirket);
                MessageBox.Show("İlan Oluşturuldu");
            }
            catch
            {
                MessageBox.Show("İlan Oluşturulamadı (ilan no yanlış)");
            }

        }
        
        private void btnGet_Click(object sender, EventArgs e)
        {
            Sirket tempSirket = new Sirket();
            tempSirket = (Sirket)(Form1.hashIsyeri.Get(Convert.ToInt32(txtGSirketNo.Text)));
            if (tempSirket != null)
            {
                gnclIAd.Text = tempSirket.ad;
                gnclITelefon.Text = tempSirket.telefon.ToString();
                gnclIFax.Text = tempSirket.fax.ToString();
                gnclIEPosta.Text = tempSirket.ePosta;
                gnclIAdres.Text = tempSirket.adres;
              

            }
            else
                MessageBox.Show("Şirket Bulunamadı");

        }

        private void btnGncll_Click(object sender, EventArgs e)
        {
            Sirket gSirket = new Sirket();
            gSirket.ad = gnclIAd.Text;
            gSirket.telefon =Convert.ToInt32(gnclITelefon.Text);
            gSirket.fax = Convert.ToInt32(gnclIFax.Text);
            gSirket.ePosta = gnclIEPosta.Text;
            gSirket.adres = gnclIAdres.Text;
            Form1.hashIsyeri.Update(Convert.ToInt32(txtGSirketNo.Text), gSirket);

        }

        private void btnIGet_Click(object sender, EventArgs e)
        {
            try {
                object ilan = Form1.ilan.Get(Convert.ToInt32(txtINo.Text));
                string bkisiler = ((Sirket)ilan).isilani.iseBasvuran.DisplayHeap();
                txtIseBasvuranlar.Text = bkisiler;
            }
            catch
            {
                MessageBox.Show("İlan bulunamadı");
            }

        }

        private void btnUygunAdayAl_Click(object sender, EventArgs e)
        {
            Kisi iseAlinan = new Kisi();
            object ilan = Form1.ilan.Get(Convert.ToInt32(txtUygnAINo.Text));
           iseAlinan=((Sirket)ilan).isilani.iseBasvuran.RemoveMax().Deger;
            MessageBox.Show(iseAlinan.Ad+" "+iseAlinan.Soyad+" İşe Alınmıştır");
        }

        private void btnSBKaydet_Click(object sender, EventArgs e)
        {
            Form1.SirketTxtYazdir(Form1.hashIsyeri.Rturn());
        }

        private void btnUygunAdayAl_Click_1(object sender, EventArgs e)
        {
            Kisi iseAlinan = new Kisi();
            object ilan = Form1.ilan.Get(Convert.ToInt32(txtUygnAINo.Text));
           /* int ilanno=((Sirket)ilan).isilani.ilanNo;
            Form1.ilan.RemoveIlan(ilanno);*/   //istenirse ilanı sildir

            iseAlinan = ((Sirket)ilan).isilani.iseBasvuran.RemoveMax().Deger;
            MessageBox.Show(iseAlinan.Ad + " " + iseAlinan.Soyad + " İşe Alınmıştır");

        }
    }
}
