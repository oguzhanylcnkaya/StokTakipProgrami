using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void Listele()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("Select * From StokKayit", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into StokKayit (StokAdi,StokModeli,StokSeriNo, StokAdedi, StokTarihi, KaydedenKisi) values (@StokAdi,@StokModeli,@StokSeriNo, @StokAdedi, @StokTarihi, @KaydedenKisi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@StokAdi", (textBox1.Text));
            komut.Parameters.AddWithValue("@StokModeli", textBox2.Text);
            komut.Parameters.AddWithValue("@StokSeriNo", textBox3.Text);
            komut.Parameters.AddWithValue("@StokAdedi", textBox4.Text);
            komut.Parameters.AddWithValue("@StokTarihi", Convert.ToDateTime(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@KaydedenKisi", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Ekleme başarıyla tamamlandı!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form2_Load(null, null);


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselProgramlamaOdevDataSet1.StokKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokKayitTableAdapter1.Fill(this.gorselProgramlamaOdevDataSet1.StokKayit);
            // TODO: Bu kod satırı 'gorselProgramlamaOdevDataSet.StokKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokKayitTableAdapter.Fill(this.gorselProgramlamaOdevDataSet.StokKayit);

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.;Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();

            Listele();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From StokKayit Where KayitNo=@KayitNo";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KayitNo", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Kayıt Silindi!");

            dataGridView1.Refresh();
            dataGridView1.Update();
            Form2_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            this.Hide();
            form3sec.Show();
        }
    }
}
