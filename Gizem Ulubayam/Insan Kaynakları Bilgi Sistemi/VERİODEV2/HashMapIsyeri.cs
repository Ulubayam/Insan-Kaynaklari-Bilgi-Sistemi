using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİODEV2
{
    [Serializable()]
    public class HashMapIsyeri
    {
        int TABLE_SIZE = 11;

        LinkedHashEntry[] table;

        public LinkedHashEntry[] Rturn()
        {
            return table;
        }

        public void TXTDENGOM(LinkedHashEntry[] frmtxt)
        {
            this.table = frmtxt;
        }
        public HashMapIsyeri()
        {
            table = new LinkedHashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                table[i] = null;
        }

        public void Update(int key,Sirket sirket)
        {
            int hash = (key % TABLE_SIZE);
            LinkedHashEntry entry = table[hash];
            while (entry != null && entry.Anahtar != key)
            {
                entry = entry.Next;

            }
           ((Sirket)entry.Deger).ad = sirket.ad;
            ((Sirket)entry.Deger).adres = sirket.adres;
            ((Sirket)entry.Deger).ePosta = sirket.ePosta;
            ((Sirket)entry.Deger).fax = sirket.fax;
            ((Sirket)entry.Deger).telefon = sirket.telefon;



        }
        public object Get(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                return null;
            else {
                LinkedHashEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return entry.Deger;
            }
        }
        public string GetAll()
        {

            string tmp = "";
            for (int i = 0; i < 10; i++)
            {
                if (table[i] != null)
                {
                    LinkedHashEntry entry = table[i];
                    while (entry != null)
                    {
                        if (entry == null)
                            return null;
                        else
                            tmp += "Sirket Adı:" + ((Sirket)table[i].Deger).ad + " İlan No:" + Convert.ToString(((Sirket)table[i].Deger).isilani.ilanNo) + " İş Tanımı:" + ((Sirket)table[i].Deger).isilani.isTanimi + " Aranan Ozellik:" + ((Sirket)table[i].Deger).isilani.arananOzellik + Environment.NewLine;

                        entry = entry.Next;
                    }
                }

            }

            return tmp;
        }
        public void Add(int key, object value)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] == null)
                table[hash] = new LinkedHashEntry(key, value);
            else {
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key)
                    entry.Deger = value;
                else
                    entry.Next = new LinkedHashEntry(key, value);
            }
        }

        public void RemoveSirket(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (table[hash] != null)
            {
                LinkedHashEntry prevEntry = null;
                LinkedHashEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                {
                    prevEntry = entry;
                    entry = entry.Next;
                }
                if (entry.Anahtar == key)
                {
                    if (prevEntry == null)
                        table[hash] = entry.Next;
                    else
                        prevEntry.Next = entry.Next;
                }
            }
        }
    }
}
