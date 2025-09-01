using Microsoft.Data.SqlClient;

namespace Hastane_Proje
{
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void linkLabeluyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayit fr = new FormHastaKayit();
            fr.Show();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormHastaDetay fr = new FormHastaDetay();
                fr.tc = maskedTextBoxTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void FormHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
