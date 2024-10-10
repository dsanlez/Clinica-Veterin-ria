using LibraryClinica;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Net;


namespace FormPrincipal
{

    public partial class Form1 : Form
    {
        int PanelWidth;
        bool isCollapsed;

        private List<Cliente> _clientes;
        private List<Medico> _medicos;
        private List<Consultas> _consultas;
        private List<Animal> _animais;


        const string nomeFicheiroAnimais = @"AnimaisInfo.txt";
        const string nomeFicheiroClientes = @"ClientesInfo.txt";
        const string nomeFicheiroMedicos = @"MedicosInfo.txt";
        const string nomeFicheiroConsultas = @"ConsultasInfo.txt";

        FormLogin login;
        public Form1(FormLogin formLogin, string username)
        {
            InitializeComponent();
            login = formLogin;

            _clientes = new List<Cliente>();
            _medicos = new List<Medico>();
            _consultas = new List<Consultas>();
            _animais = new List<Animal>();

            

            PanelWidth = sideBarContainer.Width;
            isCollapsed = false;
            timerHoras.Start();
            lblUser.Text = username;
            lblData.Text = DateTime.Now.ToString("dddd, dd.MM.yyyy", CultureInfo.CurrentUICulture);
        }

        /// <summary>
        /// Método para carregar os UserControl
        /// </summary>
        /// <param name="userControl"></param>
        private void LoadUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }

        /// <summary>
        /// Abre o user control dos clientes      
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            int nextClientId;

            if (_clientes != null && _clientes.Count != 0)
            {
                nextClientId = _clientes[_clientes.Count - 1].Id + 1;
            }
            else
            {
                nextClientId = 1;
            }

            LoadUserControl(new ClienteControl(_clientes, _consultas, nextClientId, _animais));
        }

        /// <summary>
        /// Abre o user control dos Médicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMedicos_Click_1(object sender, EventArgs e)
        {
            int nextMedicoId;

            if (_medicos != null && _medicos.Count != 0)
            {
                nextMedicoId = _medicos[_medicos.Count - 1].Id + 1;
            }
            else
            {
                nextMedicoId = 1;
            }
            LoadUserControl(new MedicosControl(_medicos, _consultas, nextMedicoId));
        }

        /// <summary>
        /// Abre o user control dos consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultas_Click_2(object sender, EventArgs e)
        {
            int nextConsultaId;

            if (_consultas != null && _consultas.Count != 0)
            {
                nextConsultaId = _consultas[_consultas.Count - 1].Id + 1;
            }
            else
            {
                nextConsultaId = 1;
            }
            LoadUserControl(new ConsultasControl(_consultas, _animais, _medicos, nextConsultaId, _clientes));
        }

        /// <summary>
        /// Abre o user control dos animais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimal_Click(object sender, EventArgs e)
        {
            int nextPetId;

            if (_animais != null && _animais.Count != 0)
            {

                nextPetId = _animais[_animais.Count - 1].Id + 1;
            }
            else
            {
                nextPetId = 1;
            }
            LoadUserControl(new AnimalControl(_clientes, _animais, _consultas, nextPetId));
        }

        /// <summary>
        /// Abre o form about
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            About formNovo = new About();
            formNovo.Show();
        }

        /// <summary>
        /// Método de control da barra lateral
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                sideBarContainer.Width = sideBarContainer.Width + 10;
                if (sideBarContainer.Width >= PanelWidth)
                {
                    sideBarTimer.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                sideBarContainer.Width = sideBarContainer.Width - 10;
                if (sideBarContainer.Width <= 57)
                {
                    sideBarTimer.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        /// <summary>
        /// Inicia o timer da SideBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuButton_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        /// <summary>
        /// Método para definir a  lblHoras com a hora atual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerHoras_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblHoras.Text = dt.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Evento onde vão ser executados os métodos para guardar os dados do programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (_clientes != null)
                {
                    GestãoDeFicheiros.GuardarClientes(_clientes, nomeFicheiroClientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (_animais != null)
                {
                    GestãoDeFicheiros.GuardarAnimais(_animais, nomeFicheiroAnimais);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar animais: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (_medicos != null)
                {
                    GestãoDeFicheiros.GuardarMedicos(_medicos, nomeFicheiroMedicos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar médicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (_consultas != null)
                {
                    GestãoDeFicheiros.GuardarConsultas(_consultas, nomeFicheiroConsultas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar consultas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Fecha o form login
            login.Close();
        }

        /// <summary>
        /// Evento onde vão ser executados os ficheiros para carregar informação guardada nos ficheiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o ficheiro existe.
                if (File.Exists(nomeFicheiroClientes))
                {
                    // Carrega a lista de alunos a partir do ficheiro.
                    _clientes = GestãoDeFicheiros.AbrirClientes(nomeFicheiroClientes);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Verifica se o ficheiro existe.
            if (File.Exists(nomeFicheiroAnimais))
            {
                // Carrega a lista de alunos a partir do ficheiro.
                _animais = GestãoDeFicheiros.AbrirAnimais(_clientes, nomeFicheiroAnimais);

            }
            try
            {
                //Verifica se o ficheiro existe.
                if (File.Exists(nomeFicheiroMedicos))
                {
                    // Carrega a lista de alunos a partir do ficheiro.
                    _medicos = GestãoDeFicheiros.AbrirMedicos(nomeFicheiroMedicos);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar médicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                //Verifica se o ficheiro existe.
                if (File.Exists(nomeFicheiroConsultas))
                {
                    // Carrega a lista de alunos a partir do ficheiro.
                    _consultas = GestãoDeFicheiros.CarregarConsultas(nomeFicheiroConsultas, _animais, _medicos);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as consultas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadUserControl(new HomeControl(_medicos, _clientes, _animais, _consultas));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HomeControl(_medicos, _clientes, _animais, _consultas));
        }
    }
}
