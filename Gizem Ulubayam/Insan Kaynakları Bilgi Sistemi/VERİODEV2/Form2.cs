using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VERİODEV2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listilan.Text = Form1.ilan.GetAll();

        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
           
            


        }

        private void btnPKayit_Click(object sender, EventArgs e)
        {
            


                
            
           
        }
       
        

        private void btnPKayit_Click_1(object sender, EventArgs e)
        {
            
           
            Kisi kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.telefon = Convert.ToInt64(txtTelefon.Text);
            kisi.ePosta = txtPosta.Text;
            kisi.uyruk = txtUyruk.Text;
            kisi.dYeri = txtDogumyeri.Text;
            kisi.dTarihi = Convert.ToDateTime(dgmTrh.Text);
            kisi.medeniDurum = txtMedenidurum.Text;
            
            kisi.yDil = txtYabancidil.Text.ToUpper();

            if (kisi.yDil == "İNGİLİZCE")
            {
                Form1.ikili.IngilizceBilenler.Add(kisi);
            }
            kisi.ilgiAlani = txtİlgialanlari.Text;
            kisi.Adres = txtAdres.Text;
            if (chckDeneyim.Checked)
            {
                IsDeneyimi iD = new IsDeneyimi();
                iD.ad = txtOncekiIsAd.Text;
                iD.adres = txtOncekiIadres.Text;
                iD.pozisyon = txtOncekiIPzsyn.Text;
                kisi.isDeneyimiEkle(iD);
            }
            EgitimDurumu egtm = new EgitimDurumu();
            egtm.oAd = txtOkulAd.Text;
           egtm.bolum = txtBolum.Text;
            egtm.basTarih = Convert.ToDateTime(BasTarihi.Text);
            egtm.bitTarih = Convert.ToDateTime(bitTarihi.Text);
            egtm.notOrt = Convert.ToInt32(txtNotOrt.Text);
            kisi.egitimDurumuEkle(egtm);
            if (egtm.notOrt >= 90)
                Form1.ikili.DoksanUstu.Add(kisi);


            

            Form1.ikili.Ekle(kisi);
            MessageBox.Show("Başarıyla Ekleme İşlemi Yapılmıştır");
          
           
           
           

        }
         

        private void grpbxDnym_Enter(object sender, EventArgs e)
        {
           
        }

        private void chckDeneyim_CheckedChanged(object sender, EventArgs e)
        {
            if (chckDeneyim.Checked)
                grpbxDnym.Visible = true;
            else
                grpbxDnym.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGncl_Click(object sender, EventArgs e)
        {
            /* */
            Kisi GncllKisi = new Kisi();
            GncllKisi.Ad = gncllAd.Text;
            GncllKisi.Soyad = gncllSoyad.Text;
            GncllKisi.telefon = Convert.ToInt64(gncllTelefon.Text);
            GncllKisi.ePosta = gncllPosta.Text;
            GncllKisi.uyruk = gncllUyruk.Text;
            GncllKisi.dYeri = gncllDyeri.Text;
            GncllKisi.dTarihi = Convert.ToDateTime(gncllDtarihi.Text);
            GncllKisi.medeniDurum = gncllMedeni.Text;

            GncllKisi.yDil = gncllYdil.Text.ToUpper();

            if (GncllKisi.yDil == "İNGİLİZCE")
            {
                Form1.ikili.IngilizceBilenler.Add(GncllKisi);
            }
            GncllKisi.ilgiAlani = gncllIalanı.Text;
            GncllKisi.Adres =guncllAdres.Text;
            if (chckDeneyim.Checked)
            {
                IsDeneyimi id = new IsDeneyimi();
                id.ad= gncllOIsAdi.Text;
                id.adres= gncllOIsAdres.Text;
                id.pozisyon=gncllOIsPoziyon.Text;
                GncllKisi.isDeneyimi.DeleteFirst();
                GncllKisi.isDeneyimi.InsertLast(id);

                
            }
            EgitimDurumu ed = new EgitimDurumu();
            ed.oAd= gncllOkulAdi.Text;
            ed.bolum= gncllBolum.Text;
            ed.basTarih=Convert.ToDateTime(gncllBasTarihi.Text);
            ed.bitTarih= Convert.ToDateTime(gncllBitTrh.Text);
            ed.notOrt= Convert.ToInt32(gncllNotOrt.Text);
            if (ed.notOrt >= 90)
                Form1.ikili.DoksanUstu.Add(GncllKisi);


            GncllKisi.egitimDurumu.DeleteFirst();
            GncllKisi.egitimDurumu.InsertLast(ed);

            Form1.ikili.Ekle(GncllKisi);
            
            MessageBox.Show("Başarıyla Güncelleme İşlemi Yapılmıştır");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGuncllDnym.Checked)
                gncllgroup.Visible = true;
            else
                gncllgroup.Visible = false;
        }

        private void btnbasvur_Click(object sender, EventArgs e)
        {
            Kisi BasvuranKisi = Form1.ikili.Ara(txtbasvuracakbul.Text).veri;
            
            if(BasvuranKisi!=null)
            {

                

                int ilanno = Convert.ToInt32(txtiNo.Text);
                object ilan = Form1.ilan.Get(ilanno);
                
                //ilan no ya göre ara
                if (Form1.ilan.Get(ilanno)==null)
                    MessageBox.Show("İlan Bulunamadı");  //İlan olup olmadığı sorgusu
              else if(((Sirket)ilan).isilani.iseBasvuran.Kontrol(BasvuranKisi))
                    MessageBox.Show("Daha Önceden Başvurunuz Var");
                else
                {
                    Form1.ilan.isIlaninaBasvuranEkle(ilanno, BasvuranKisi);
                }

                //bana ilanı veren şirketi getirdi (null dönerse exeption)
                //her şirketin ilanına başvuran kişiler heapde tutuluyor
                //sirket.isebasvuran kişilere ekle
                //Şirketi bulup ise basvuranlara ekleme yapmam gerek kişi yi parametre olarak atamalıyım
                //ilana basvuran kişiler olur ilan basvuran kişiler tut heap 
            

            }
            else
                MessageBox.Show("Aradığınız Kişi Bulunamadı");

        }
        
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.ikili.IngilizceBilenler.Count; i++)
            {

                listIngB.Items.Add(Form1.ikili.IngilizceBilenler[i].Ad + Form1.ikili.IngilizceBilenler[i].Soyad);
                    
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Form1.ikili.Sil(txtSKisi.Text)==true)
            MessageBox.Show("Kişi Silindi");
            else
                MessageBox.Show("Kişi Bulunamadı");

        }

        private void btnKisiGetir_Click(object sender, EventArgs e)
        {
            Kisi tmpKisi = new Kisi();
            tmpKisi = Form1.ikili.Ara(txtGuncelKisi.Text).veri;
            if (tmpKisi == null)
            {
                MessageBox.Show("Kişi Bulunamadı");
            }
            else
            {
                gncllAd.Text = tmpKisi.Ad;
                gncllSoyad.Text = tmpKisi.Soyad;
                gncllTelefon.Text = tmpKisi.telefon.ToString();
                gncllPosta.Text = tmpKisi.ePosta;
                gncllUyruk.Text = tmpKisi.uyruk;
                gncllDyeri.Text = tmpKisi.dYeri;
                gncllDtarihi.Text = (tmpKisi.dTarihi.Date.Day + "/" + tmpKisi.dTarihi.Date.Month + "/" + tmpKisi.dTarihi.Date.Year).ToString();
                gncllMedeni.Text = tmpKisi.medeniDurum;
                gncllYdil.Text = tmpKisi.yDil;
                gncllIalanı.Text = tmpKisi.ilgiAlani;
                guncllAdres.Text = tmpKisi.Adres;

                if(tmpKisi.isDeneyimi.Head!=null)
                    {
                    gncllOIsAdi.Text = ((IsDeneyimi)tmpKisi.isDeneyimi.Head.Data).ad;
                    gncllOIsAdres.Text = ((IsDeneyimi)tmpKisi.isDeneyimi.Head.Data).adres;
                    gncllOIsPoziyon.Text = ((IsDeneyimi)tmpKisi.isDeneyimi.Head.Data).pozisyon;
                }
              

                gncllOkulAdi.Text = ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).oAd;
                gncllBolum.Text = ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).bolum;
                gncllBasTarihi.Text = (((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).basTarih.Date.Day + "/" + ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).basTarih.Date.Month + "/" + ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).basTarih.Year).ToString();
                gncllBitTrh.Text = (((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).bitTarih.Date.Day + "/" + ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).bitTarih.Date.Month + "/" + ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).bitTarih.Date.Day).ToString();
                gncllNotOrt.Text = ((EgitimDurumu)tmpKisi.egitimDurumu.Head.Data).notOrt.ToString();

                Form1.ikili.Sil(txtGuncelKisi.Text);
            }
        }

        private void btnDokListele_Click(object sender, EventArgs e)
        {
            listDoksanUstu.Items.Clear();   
            for (int i = 0; i < Form1.ikili.DoksanUstu.Count; i++)
            {

                listDoksanUstu.Items.Add(Form1.ikili.DoksanUstu[i].Ad + Form1.ikili.DoksanUstu[i].Soyad);

            }
        }

        private void btnIslemListele_Click(object sender, EventArgs e)
        {
            listBoxInOrder.Items.Clear();
            listBoxPreOrder.Items.Clear();
            listBoxPostOrder.Items.Clear();
            Form1.ikili.InOrder();
            Form1.ikili.PreOrder();
            Form1.ikili.PostOrder();
            foreach (Kisi ListIn in Form1.ikili.InOrderList)
            {
                listBoxInOrder.Items.Add(ListIn.Ad + " " + ListIn.Soyad);
            }

            foreach (Kisi ListPre in Form1.ikili.PreOrderList)
            {
                listBoxPreOrder.Items.Add(ListPre.Ad + " " + ListPre.Soyad);
            }
            foreach (Kisi ListPost in Form1.ikili.PostOrderList)
            {
                listBoxPostOrder.Items.Add(ListPost.Ad + " " + ListPost.Soyad);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ikili.PreOrder();
            Form1.txtYazdir(Form1.ikili.PreOrderList);

        }
    }
}
