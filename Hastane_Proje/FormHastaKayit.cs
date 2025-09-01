using Microsoft.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FormHastaKayit : Form
    {
        public FormHastaKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtelno.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı. Şireniz: " + textBoxSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
