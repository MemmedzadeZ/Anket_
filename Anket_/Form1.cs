using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Anket_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ad = label1.Text; 
            string soyad = label2.Text;
            string ataAdi = label3.Text;
            string olke = label4.Text;
            string seher = label5.Text;
            string telefon = label6.Text;
            //  DateTimePicker date = dateTimePicker1.Text;

            People people = new People { Ad = ad, Soyad = soyad, AtaAdi = ataAdi, Olke = olke, Sheher = seher, Telefon = telefon };

            string json = JsonConvert.SerializeObject(people);

            File.WriteAllText($"{ad}.json", json);

            MessageBox.Show("Verilen json file yuklendi");


        }
    }
}