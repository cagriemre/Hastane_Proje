namespace Hastane_Proje
{
    public partial class FormGirisler : Form
    {
        public FormGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //týklama iþlemi

        }

        private void buttonHastaGirisi_Click(object sender, EventArgs e)
        {
            FormHastaGiris fr = new FormHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void buttonDoktorGirisi_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void buttonSekreterGirisi_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr = new FormSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
