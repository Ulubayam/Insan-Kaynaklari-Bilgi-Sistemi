using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class Sirket
    {
        public string ad { get; set; }
        public string adres { get; set; }
        public long telefon { get; set; }
        public long fax { get; set; }
        public string ePosta { get; set; }
        public int sirketNo { get; set; }
        public IsIlani isilani;

       public void IsIlaniOlustur(IsIlani Is)
        {
            
            Form1.ilan.Add(Is.ilanNo, this);

        }

        
        public Sirket()
        {
            
            Random r = new Random();
            sirketNo = r.Next();
        }

    }
}
