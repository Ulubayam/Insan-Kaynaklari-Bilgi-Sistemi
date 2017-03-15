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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace VERİODEV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in txtOku())
            {
                
                ikili.Ekle(item);
            }
          hashIsyeri.TXTDENGOM(txtİsyeriOku());
        

        }
      public static void txtYazdir(List<Kisi> txtyazdir)
        {
            Stream stream = File.Open(Environment.CurrentDirectory+"\\kisiler.txt", FileMode.Create);
            var bFormatter = new BinaryFormatter();
            bFormatter.AssemblyFormat =
            System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            bFormatter.Serialize(stream, txtyazdir);
            stream.Close();
        }
        public static void SirketTxtYazdir(LinkedHashEntry[] txtyazdir)
        {
            Stream stream = File.Open(Environment.CurrentDirectory + "\\sirketler.txt", FileMode.Create);
            var bFormatter = new BinaryFormatter();
            bFormatter.AssemblyFormat =
            System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
            bFormatter.Serialize(stream, txtyazdir);
            stream.Close();
        }
        public static List<Kisi> txtOku()
        {
            Stream stream = File.Open(Environment.CurrentDirectory + "\\kisiler.txt", FileMode.Open);
            var bFormatter = new BinaryFormatter();
            var objectToSerialize = (List<Kisi>)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
       public static LinkedHashEntry[] txtİsyeriOku()
        {
            Stream stream = File.Open(Environment.CurrentDirectory + "\\sirketler.txt", FileMode.Open);
            var bFormatter = new BinaryFormatter();
            var objectToSerialize = (LinkedHashEntry[])bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
          
        }

        private void btnSirket_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
           
        }
    }
}
