using Microsoft.Data.SqlClient;
using System.Data;

namespace Hastane_Proje
{
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tc;

            // Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", labelTC.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // Branşlar
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktor Çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+ ' '+DoktorSoyad) as 'Doktorlar',DoktorBrans from Tbl_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branş Çekme 
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
                bgl.baglanti().Close();
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor)values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTextBoxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", maskedTextBoxSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBoxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", comboBoxDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void buttonDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBoxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRandevuPanel_Click(object sender, EventArgs e)
        {
            FormDoktorPaneli fr = new FormDoktorPaneli();
            fr.Show();
        }

        private void buttonBransPaneli_Click(object sender, EventArgs e)
        {
            FormBransPaneli ft = new FormBransPaneli();
            ft.Show();
        }

        private void buttonRandevuList_Click(object sender, EventArgs e)
        {
            FormRandevuListesi fr = new FormRandevuListesi();
            fr.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }
    }
}
