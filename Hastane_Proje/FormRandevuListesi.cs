using Microsoft.Data.SqlClient;
using System.Data;

namespace Hastane_Proje
{
    public partial class FormRandevuListesi : Form
    {
        public FormRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FormRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select* from Tbl_Randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
