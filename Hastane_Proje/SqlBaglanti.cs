using Microsoft.Data.SqlClient;

namespace Hastane_Proje
{
    internal class SqlBaglanti
    {
        private readonly string connectionString = "Data Source=DESKTOP-UI4QO3R\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True;TrustServerCertificate=True;";
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(connectionString);
            baglan.Open();
            return baglan;
        }
    }
}
