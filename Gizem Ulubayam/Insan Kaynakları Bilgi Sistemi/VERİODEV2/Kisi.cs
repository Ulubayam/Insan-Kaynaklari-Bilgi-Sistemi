using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public long telefon { get; set; }
        public string ePosta { get; set; }
        public string uyruk { get; set; }
        public string dYeri { get; set; }
        public DateTime dTarihi { get; set; }
        public string medeniDurum { get; set; }
        public string yDil { get; set; }
        public string ilgiAlani { get; set; }
        public string referans { get; set; }
        public double uDurumu { get; set; }
        public LinkedList isDeneyimi;
        public LinkedList egitimDurumu; 
       // public IsDeneyimi isDeneyimi;
       // public EgitimDurumu egitimDurumu;
        public Kisi()
        {
            uDurumu = GetRandomNumber(0.0,10.0);
            isDeneyimi = new LinkedList();
           egitimDurumu = new LinkedList();

        }
        public void egitimDurumuEkle(EgitimDurumu egtm)
        {
            egitimDurumu.InsertLast(egtm);
        }
        public void isDeneyimiEkle(IsDeneyimi isDnym)
        {
            isDeneyimi.InsertLast(isDnym);
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
