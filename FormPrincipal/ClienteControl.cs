using LibraryClinica;


namespace FormPrincipal
{
    public partial class ClienteControl : UserControl
    {
        private List<Cliente> listaClientes;
        private List<Consultas> listaConsultas;
        private List<Animal> _listaAnimais;

        private static int _nextClienteId = 1;
        public ClienteControl(List<Cliente> clientes, List<Consultas> listaConsultasPet, int nextClientId, List<Animal> listaAnimais)
        {
            InitializeComponent();
            listaClientes = clientes;
            listaConsultas = listaConsultasPet;
            _listaAnimais = listaAnimais;
            InitLista(listaClientes);
            cBoxFiltrarClientes();

            listBoxClientes.SelectedItem = null;
            LimparCampos();

            _nextClienteId = nextClientId;
            textBoxIdCliente.Text = nextClientId.ToString();
        }

        /// <summary>
        /// Cria um novo Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDadosCliente(_nextClienteId))
            {
                Cliente cliente = new Cliente
                {
                    Id = _nextClienteId,
                    Nome = textBoxNomeCliente.Text,
                    Apelido = textBoxApelido.Text,
                    Morada = textBoxMorada.Text,
                    Telefone = textBoxTelefone.Text,
                    NIF = textBoxNif.Text,
                    Animais = new List<Animal>()
                };
                _nextClienteId++;
                listaClientes.Add(cliente);
                InitLista(listaClientes);
                LimparCampos();
                textBoxIdCliente.Text = _nextClienteId.ToString();
            }
        }

        /// <summary>
        /// Limpar campos
        /// </summary>
        private void LimparCampos()
        {
            textBoxNomeCliente.Text = string.Empty;
            textBoxApelido.Text = string.Empty;
            textBoxMorada.Text = string.Empty;
            textBoxTelefone.Text = string.Empty;
            textBoxNif.Text = string.Empty;
        }

        /// <summary>
        /// Inicia e atualiza os dados na ListBox
        /// </summary>
        public void InitLista(List<Cliente> listaClientes)
        {
            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = listaClientes;
            listBoxClientes.DisplayMember = "IdNome";
        }

        /// <summary>
        /// Apaga o cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;

                if (clienteSelecionado != null)
                {
                    DialogResult resposta = MessageBox.Show($"Tem a certeza que quer apagar o {clienteSelecionado.Nome}? Todos os Pets do mesmo serão apagados !",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        List<Animal> animaisParaRemover = _listaAnimais.Where(animal => animal.Dono.Id == clienteSelecionado.Id).ToList();
                        foreach (var animal in animaisParaRemover)
                        {
                            _listaAnimais.Remove(animal);
                        }

                        listaClientes.Remove(clienteSelecionado);
                        InitLista(listaClientes);
                        LimparCampos();
                    }
                }
            }
        }

        /// <summary>
        /// Atualiza os dados do cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null && ValidarDadosCliente(Convert.ToInt32(textBoxIdCliente.Text)))
            {

                Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;

                if (clienteSelecionado != null)
                {
                    bool clienteAlterado = false;

                    // Verifica se houve alterações nos dados do cliente
                    if (clienteSelecionado.Nome != textBoxNomeCliente.Text ||
                        clienteSelecionado.Apelido != textBoxApelido.Text ||
                        clienteSelecionado.Morada != textBoxMorada.Text ||
                        clienteSelecionado.Telefone != textBoxTelefone.Text ||
                        clienteSelecionado.NIF != textBoxNif.Text)
                    {
                        clienteSelecionado.Nome = textBoxNomeCliente.Text;
                        clienteSelecionado.Apelido = textBoxApelido.Text;
                        clienteSelecionado.Morada = textBoxMorada.Text;
                        clienteSelecionado.Telefone = textBoxTelefone.Text;
                        clienteSelecionado.NIF = textBoxNif.Text;
                        clienteAlterado = true;
                    }

                    if (clienteAlterado)
                    {
                        MessageBox.Show("Cliente editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração feita.");
                    }
                }
                
                InitLista(listaClientes);
                listBoxClientes.SelectedItem = null;
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um cliente na lista! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Mostra os dados do cliente selecionado nas texBox .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                Cliente clienteSelecionado = listBoxClientes.SelectedItem as Cliente;

                if (clienteSelecionado != null)
                {
                    textBoxIdCliente.Text = clienteSelecionado.Id.ToString();
                    textBoxNomeCliente.Text = clienteSelecionado.Nome;
                    textBoxApelido.Text = clienteSelecionado.Apelido;
                    textBoxMorada.Text = clienteSelecionado.Morada;
                    textBoxTelefone.Text = clienteSelecionado.Telefone;
                    textBoxNif.Text = clienteSelecionado.NIF;
                }
                if (clienteSelecionado != null && clienteSelecionado.Animais != null && clienteSelecionado.Animais.Count > 0)
                {
                    btnDadosPets.Enabled = true;
                }
                else
                {
                    btnDadosPets.Enabled = false;
                }

            }
        }

        /// <summary>
        /// Procura o cliente através da opção escolhida na comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrarLista_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxFiltrarLista.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                InitLista(listaClientes);
                return;
            }

            var filteredClients = new List<Cliente>();

            string filtroSelecionado = cmbFiltrarClientes.SelectedItem.ToString();

            foreach (var cliente in listaClientes)
            {
                switch (filtroSelecionado)
                {
                    case "Nome":
                        if (cliente.Nome.ToLower().Contains(searchText))
                        {
                            filteredClients.Add(cliente);
                        }
                        break;

                    case "Apelido":
                        if (cliente.Apelido.ToLower().Contains(searchText))
                        {
                            filteredClients.Add(cliente);
                        }
                        break;

                    case "NIF":
                        if (cliente.NIF.StartsWith(searchText))
                        {
                            filteredClients.Add(cliente);
                        }
                        break;

                    case "Telefone":
                        if (cliente.Telefone.StartsWith(searchText))
                        {
                            filteredClients.Add(cliente);
                        }
                        break;
                }
            }

            InitLista(filteredClients);
        }

        /// <summary>
        /// Validar Campos
        /// </summary>
        /// <returns></returns>
        private bool ValidarDadosCliente(int id)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeCliente.Text))
            {
                MessageBox.Show("Insira o nome do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            string pattern = @"^[a-zA-Z\s]+$";

            // Verifica se o nome contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxNomeCliente.Text, pattern))
            {
                MessageBox.Show("O nome do cliente não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (listaClientes.FirstOrDefault(c => c.NIF.Equals(textBoxNif.Text) && c.Id != id) != null)
            {
                MessageBox.Show("O NIF inserido já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxApelido.Text))
            {
                MessageBox.Show("Insira o apelido do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica se o apelido contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxApelido.Text, pattern))
            {
                MessageBox.Show("O apelido do cliente não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxMorada.Text))
            {
                MessageBox.Show("Insira a morada do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (listaClientes.FirstOrDefault(c => c.Telefone.Equals(textBoxTelefone.Text) && c.Id != id) != null)
            {
                MessageBox.Show("O número de telefone inserido já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTelefone.Text))
            {
                MessageBox.Show("Insira o telefone do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxTelefone.Text.Length != 9 || !int.TryParse(textBoxTelefone.Text, out int telefone))
            {
                MessageBox.Show("O campo Telefone deve conter exatamente 9 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNif.Text))
            {
                MessageBox.Show("Insira o NIF do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxNif.Text.Length != 9 || !int.TryParse(textBoxNif.Text, out int nif))
            {
                MessageBox.Show("O campo NIF deve conter exatamente 9 dígitos numéricos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Ver dados dos pets do dono selecionado na listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDadosPets_Click(object sender, EventArgs e)
        {

            Cliente donoSelecionado = listBoxClientes.SelectedItem as Cliente;
            if (donoSelecionado != null)
            {
                FormVerPets formVerPets = new FormVerPets(donoSelecionado.Animais, listaConsultas);
                formVerPets.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um dono.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Adiciona opções de filtragem à comboBox e estabelece a opção "Nome" como opção default
        /// </summary> 
        private void cBoxFiltrarClientes()
        {
            cmbFiltrarClientes.Items.Add("Nome");
            cmbFiltrarClientes.Items.Add("Apelido");
            cmbFiltrarClientes.Items.Add("NIF");
            cmbFiltrarClientes.Items.Add("Telefone");
            cmbFiltrarClientes.SelectedIndex = 0;

        }
    }
}
