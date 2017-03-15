using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class HeapDugumu
    {
        public Kisi Deger { get; set; }
       
        public HeapDugumu(Kisi deger)
        {
            this.Deger = deger;
        }
        
    }
}
