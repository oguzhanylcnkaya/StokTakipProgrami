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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SqlConnection bag = new SqlConnection("server=.; Initial Catalog=GorselProgramlamaOdev;Integrated Security=SSPI");
        public DataTable tablo = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand kmt = new SqlCommand();
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gorselProgramlamaOdevDataSet2.StokKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokKayitTableAdapter.Fill(this.gorselProgramlamaOdevDataSet2.StokKayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select * From StokKayit", bag);
            if (textBox1.Text.Trim() == "")
            {
                tablo.Clear();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from StokKayit";
                adtr.SelectCommand = kmt;
                adtr.Fill(tablo);
            }
            if (Convert.ToBoolean(bag.State) == false)
            {
                bag.Open();
            }
            if (textBox1.Text.Trim() != "")
            {
                adtr.SelectCommand.CommandText = " Select * From StokKayit" +
                     " where(StokAdi='" + textBox1.Text + "' )";
                tablo.Clear();
                adtr.Fill(tablo);
                bag.Close();
            }
        }
    }
}
