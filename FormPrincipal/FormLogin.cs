using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FormPrincipal
{

    public partial class FormLogin : Form
    {
        private List<Utilizador> _listUtilizadores;

        const string nomeFicheiroUtilizadores = @"UtilizadoresInfo.txt";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
            );
        public FormLogin()
        {
            InitializeComponent();
            _listUtilizadores = new List<Utilizador>();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Utilizador utilizador = _listUtilizadores.FirstOrDefault(u => u.username.Equals(textBoxUserName.Text));
            if (utilizador == null)
            {
                MessageBox.Show("Utilizador não existe!");
            }
            else if (!utilizador.password.Equals(textBox2Password.Text))
            {
                MessageBox.Show("Password inválida!");
                textBox2Password.Text = string.Empty;
            }
            else
            {
                Form1 form1 = new Form1(this, utilizador.username);
                this.Hide();
                form1.Show();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            if (textBoxPanelLog.Text == "Username" || string.IsNullOrWhiteSpace(textBoxPanelLog.Text) || textBoxPanelLog.Text.Length < 8)
            {
                MessageBox.Show("Insira um username válido. Mínimo 8 caracters");
                return;
            }

            if (textBoxPanelPass.Text == "Password" || string.IsNullOrWhiteSpace(textBoxPanelPass.Text) || textBoxPanelPass.Text.Length < 8)
            {
                MessageBox.Show("Insira uma password válida. Mínimo 8 caracters");
                return;
            }

            if (_listUtilizadores.FirstOrDefault(u => u.username.Equals(textBoxPanelLog.Text)) != null)
            {
                MessageBox.Show("O nome de utilizador já existe.");
                return;
            }

            Utilizador utilizador = new Utilizador();
            utilizador.username = textBoxPanelLog.Text;
            utilizador.password = textBoxPanelPass.Text;
            _listUtilizadores.Add(utilizador);

            GestãoDeFicheiros.GuardarUtilizadores(_listUtilizadores, nomeFicheiroUtilizadores);

            MessageBox.Show("Registado com sucesso! ");

            panelSignUp.Visible = false;
            panelLogIn.Dock = DockStyle.Fill;
            panelLogIn.Visible = true;


        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExitPanel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelSignUp.Visible = false;
            panelLogIn.Dock = DockStyle.Fill;
            panelLogIn.Visible = true;

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogIn.Visible = false;
            panelSignUp.Visible = true;
            panelSignUp.Dock = DockStyle.Fill;

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            _listUtilizadores = GestãoDeFicheiros.CarregarUtilizadores(nomeFicheiroUtilizadores);
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void pictureBoxSignUp_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
