namespace Faculverso
{
    public partial class AMenu : Form
    {
        public AMenu()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            BVisNov VN = new BVisNov();
            VN.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTuto_Click(object sender, EventArgs e)
        {
            CTutorial Tuto = new CTutorial();
            Tuto.Show();
            this.Hide();
        }

        private void btnCred_Click(object sender, EventArgs e)
        {
            DCreditos Cred = new DCreditos();
            Cred.Show();
            this.Hide();
        }
    }
}
