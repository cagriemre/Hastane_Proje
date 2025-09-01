using Microsoft.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FormBilgiDuzenle : Form
    {
        public FormBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tcno;
        public string ad, soyad;
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad= @p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBoxtelno.Text);
            komut2.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", maskedTextBoxTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormBilgiDuzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxTC.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                maskedTextBoxtelno.Text = dr[4].ToString();
                textBoxSifre.Text = dr[5].ToString();
                comboBoxCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
