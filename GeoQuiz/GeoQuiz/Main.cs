namespace GeoQuiz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            Land l = new Land();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        private void btnHaupt_Click(object sender, EventArgs e)
        {
            Haupt h = new Haupt();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            Flag f = new Flag();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            Highscore hi = new Highscore();
            this.Hide();
            hi.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
