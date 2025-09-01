using Microsoft.Data.SqlClient;
using System.Data;

namespace Hastane_Proje
{
    public partial class FormDoktorPaneli : Form
    {
        public FormDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Branş Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
                bgl.baglanti().Close();
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxAd.Text = dataGridView1.Rows[secilen].Cells[1].ToolTipText;
            textBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].ToolTipText;
            comboBoxBrans.Text = dataGridView1.Rows[secilen].Cells[3].ToolTipText;
            maskedTextBoxTC.Text = dataGridView1.Rows[secilen].Cells[4].ToolTipText;
            textBoxSifre.Text = dataGridView1.Rows[secilen].Cells[5].ToolTipText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            comboBoxBrans.Text = "";
            maskedTextBoxTC.Text = "";
            textBoxSifre.Text = "";
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set DoktorAd=@d1,DoktorSoyad=@d2, DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
