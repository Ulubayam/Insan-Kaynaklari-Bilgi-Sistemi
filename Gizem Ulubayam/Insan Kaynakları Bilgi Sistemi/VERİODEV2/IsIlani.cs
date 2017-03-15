using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class IsIlani
    {
        public int ilanNo { get; set; }
        public string isTanimi { get; set; }
        public string arananOzellik { get; set; }
        public Heap iseBasvuran;
        public void iseBasvuranKisiEkle(Kisi isebasvuranKisi)
        {
            iseBasvuran.Insert(isebasvuranKisi);
           
        }

       

        public IsIlani()
        {

            iseBasvuran = new Heap(10);
            Random r = new Random();
            ilanNo = r.Next();
        }
    }
}
