using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAUygulama_OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

      
        List<Musteri> musteriler = new List<Musteri>();

     
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri kisi = new Musteri();
            kisi.AdSoyad = txtAdSoyad.Text;
            kisi.Telefon = txtTelefon.Text;
            kisi.Yas = (int)nudYas.Value;
            kisi.Adres = txtAdres.Text;

            musteriler.Add(kisi);
            MessageBox.Show("Kaydetme islemi basarili!");

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            nudYas.Value = 0;
        }

        private void btnListeyeDon_Click(object sender, EventArgs e)
        {
          
            Form1 form1 = new Form1(musteriler);
            form1.Show();
            this.Hide();
        }
     
    }
}
