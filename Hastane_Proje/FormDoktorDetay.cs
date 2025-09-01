using Microsoft.Data.SqlClient;
using System.Data;

namespace Hastane_Proje
{
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        public string tc;
        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = tc;

            //Ad Soyad çekme 
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labelTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='" + labelAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle fr = new DoktorBilgiDuzenle();
            fr.tc = labelTC.Text;
            fr.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular fr = new FormDuyurular();
            fr.Show();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBoxSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
