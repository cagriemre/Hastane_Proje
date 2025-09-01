using Microsoft.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class DoktorBilgiDuzenle : Form
    {
        public DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti bgl = new SqlBaglanti();
        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxTC.Text = tc;

            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktor where DoktorTC=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString();
                textBoxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
            // Eğer bu olayı kullanmayacaksan bile boş bırakabilirsin
        }
        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            // Bu olay kullanılmıyorsa, boş bırakabilirsin
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Bu olay kullanılmıyorsa, boş bırakabilirsin
        }
    }
}
