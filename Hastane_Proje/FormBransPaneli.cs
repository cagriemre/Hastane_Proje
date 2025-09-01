using Microsoft.Data.SqlClient;
using System.Data;

namespace Hastane_Proje
{
    public partial class FormBransPaneli : Form
    {
        public FormBransPaneli()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Brans (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textBoxBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBoxBransID.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            textBoxBransAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Brans where Bransid = @b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textBoxBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Brans set BransAd = @b1 where  bransid=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textBoxBransAd.Text);
            komut.Parameters.AddWithValue("@b2", textBoxBransID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
