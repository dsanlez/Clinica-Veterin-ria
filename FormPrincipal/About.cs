using System.Diagnostics;

namespace FormPrincipal
{
    public partial class About : Form
    {
        string versao = "Versão 1.0.1";
        string data = "01/07/2024";
        public About()
        {
            InitializeComponent();
            lblVersao.Text = versao;
            lblData.Text = data;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/diogo-sanlez-051915244/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var url = "https://www.linkedin.com/in/diogo-sanlez-051915244/";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message);
            }
        }
    }
}
