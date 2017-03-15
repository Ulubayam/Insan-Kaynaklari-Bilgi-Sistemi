using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class EgitimDurumu
    {
        public string oAd { get; set; }
        public string bolum { get; set; }
        public DateTime basTarih { get; set; }
        public DateTime bitTarih { get; set; }
        public int notOrt { get; set; }

    }
}
