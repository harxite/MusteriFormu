namespace WFAUygulama_OOP
{
    public partial class Form1 : Form
    {
        List<Musteri> kisiler = new List<Musteri>();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<Musteri> musteriler)
        {
            InitializeComponent();
            kisiler = musteriler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Musteri musteri in kisiler)
            {
                lstMusteriler.Items.Add(musteri.AdSoyad);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = lstMusteriler.SelectedIndex;
            string info = $"Adi Soyadi : {kisiler[indeks].AdSoyad}\n" +
                $"Yasi : {kisiler[indeks].Yas}\n" +
                $"Telefonu: {kisiler[indeks].Telefon}\n" +
                $"Adresi : {kisiler[indeks].Adres}";
           
            MessageBox.Show(info, "Musteri Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}