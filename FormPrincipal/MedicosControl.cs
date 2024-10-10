using LibraryClinica;
using System.Data;


namespace FormPrincipal
{
    public partial class MedicosControl : UserControl
    {
        private List<Medico> listaMedicos;
        private List<Consultas> _consultasMedicos;
        private static int _nextMedicoId = 1;

        public MedicosControl(List<Medico> medicos, List<Consultas> consultasMedicos, int nextMedicoId)
        {
            InitializeComponent();
            listaMedicos = medicos;
            _consultasMedicos = consultasMedicos;

            cBoxFiltrarMedicos();
            InitLista(listaMedicos);

            textBoxIdMedico.Text = _nextMedicoId.ToString();
            _nextMedicoId = nextMedicoId;

            listBoxMedicos.SelectedItem = null;
            LimparCampos();
        }

        /// <summary>
        /// Iniciar/Atualizar Lista
        /// </summary>
        /// <param name="listaMedicos"></param>
        public void InitLista(List<Medico> listaMedicos)
        {
            listBoxMedicos.DataSource = null;
            listBoxMedicos.DataSource = listaMedicos;
            listBoxMedicos.DisplayMember = "IdNome";
        }

        /// <summary>
        /// Limpar Campos
        /// </summary>
        private void LimparCampos()
        {
            textBoxNomeMedico.Clear();
            textBoxApelido.Clear();
            textBoxEspecialidade.Clear();
            textBoxConsultorio.Clear();
            textBoxTelefoneMedico.Clear();
            textBoxIdMedico.Text = _nextMedicoId.ToString();
        }

        /// <summary>
        /// Validar Dados
        /// </summary>
        /// <returns></returns>
        private bool ValidarDadosMedico(int id)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomeMedico.Text))
            {
                MessageBox.Show("Insira o nome do médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string pattern = @"^[a-zA-Z\s]+$";

            // Verifica se o nome contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxNomeMedico.Text, pattern))
            {
                MessageBox.Show("O nome do cliente não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (string.IsNullOrWhiteSpace(textBoxApelido.Text))
            {
                MessageBox.Show("Insira o Apelido do médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            // Verifica se o apelido contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxApelido.Text, pattern))
            {
                MessageBox.Show("O apelido do cliente não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (textBoxTelefoneMedico.Text.Length != 9 || !textBoxTelefoneMedico.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira um número de telefone válido com 9 dígitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (listaMedicos.FirstOrDefault(m => m.Telefone.Equals(textBoxTelefoneMedico.Text) && m.Id != id) != null)
            {
                MessageBox.Show("O número de telefone inserido já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEspecialidade.Text))
            {
                MessageBox.Show("Insira a especialidade do médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

          
            if (!int.TryParse(textBoxConsultorio.Text, out int consultorio))
            {
                MessageBox.Show("Insira um número válido para o consultório!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Registar Médico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            if (ValidarDadosMedico(_nextMedicoId))
            {
                try
                {
                    Medico medico = new Medico
                    {
                        Id = _nextMedicoId,
                        Nome = textBoxNomeMedico.Text,
                        Apelido = textBoxApelido.Text,
                        Especialidade = textBoxEspecialidade.Text,
                        Consultorio = int.Parse(textBoxConsultorio.Text),
                        Telefone = textBoxTelefoneMedico.Text
                    };

                    _nextMedicoId++;

                    listaMedicos.Add(medico);

                    listBoxMedicos.SelectedItem = null;
                    InitLista(listaMedicos);
                    LimparCampos();
                    textBoxIdMedico.Text = _nextMedicoId.ToString();
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// Editar Dados Médico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            if (listBoxMedicos.SelectedItem != null && ValidarDadosMedico(Convert.ToInt32(textBoxIdMedico.Text)))
            {
                Medico medicoSelecionado = listBoxMedicos.SelectedItem as Medico;

                if (medicoSelecionado != null)
                {
                    bool medicoAlterado = false;

                    // Verifica se houve alterações nos dados do médico
                    if (medicoSelecionado.Nome != textBoxNomeMedico.Text ||
                        medicoSelecionado.Apelido != textBoxApelido.Text ||
                        medicoSelecionado.Especialidade != textBoxEspecialidade.Text ||
                        medicoSelecionado.Consultorio != int.Parse(textBoxConsultorio.Text) ||
                        medicoSelecionado.Telefone != textBoxTelefoneMedico.Text)
                    {
                        try
                        {
                            medicoSelecionado.Nome = textBoxNomeMedico.Text;
                            medicoSelecionado.Apelido = textBoxApelido.Text;
                            medicoSelecionado.Especialidade = textBoxEspecialidade.Text;
                            medicoSelecionado.Consultorio = int.Parse(textBoxConsultorio.Text);
                            medicoSelecionado.Telefone = textBoxTelefoneMedico.Text;
                            medicoAlterado = true;
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show("Erro ao editar médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (medicoAlterado)
                    {
                        MessageBox.Show("Médico editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração feita.");
                    }

                    InitLista(listaMedicos);
                    listBoxMedicos.SelectedItem = null;
                    LimparCampos();
                }
               
            }
            else
            {
                MessageBox.Show("Selecione um médico na lista! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Remover Medicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///        
        private void btnApagarMedico_Click(object sender, EventArgs e)
        {
            Medico? medicoSelecionado = listBoxMedicos.SelectedItem as Medico;

            Medico? medicoParaApagar = null;

            if (medicoSelecionado != null)
            {
                foreach (Medico medico in listaMedicos)
                {
                    if (medicoSelecionado.Id == medico.Id)
                    {
                        medicoParaApagar = medico;
                        break;
                    }
                }

                if (medicoParaApagar != null)
                {
                    DialogResult resposta = MessageBox.Show($"Tem a certeza que quer apagar o {medicoParaApagar.Nome}? Todas as consultas do mesmo serão apagadas !",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        List<Consultas> consultaParaRemover = _consultasMedicos.Where(c => c.Medico.Id == medicoSelecionado.Id).ToList();
                        foreach (var consulta in consultaParaRemover)
                        {
                            _consultasMedicos.Remove(consulta);
                        }

                        listaMedicos.Remove(medicoParaApagar);
                        InitLista(listaMedicos);
                        LimparCampos();
                    }
                }
            }
        }

        /// <summary>
        /// Mostar dados do médico quando selecionado na listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMedicos.SelectedItem != null)
            {
                Medico medicoSelecionado = listBoxMedicos.SelectedItem as Medico;

                if (medicoSelecionado != null)
                {
                    textBoxIdMedico.Text = medicoSelecionado.Id.ToString();
                    textBoxNomeMedico.Text = medicoSelecionado.Nome;
                    textBoxApelido.Text = medicoSelecionado.Apelido;
                    textBoxEspecialidade.Text = medicoSelecionado.Especialidade;
                    textBoxConsultorio.Text = medicoSelecionado.Consultorio.ToString();
                    textBoxTelefoneMedico.Text = medicoSelecionado.Telefone;

                    // Verifica se o médico tem consultas agendadas
                    List<Consultas> consultaDoMedicoSelecionado = _consultasMedicos.Where(c => c.Medico.Id == medicoSelecionado.Id).ToList();
                    btnConsultasMedico.Enabled = consultaDoMedicoSelecionado.Count > 0;
                }
                else
                {
                    btnConsultasMedico.Enabled = false;
                }
            }
            else
            {
                btnConsultasMedico.Enabled = false;
            }

        }
                    
        /// <summary>
        /// Abre as consulta do médico selecionado na lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultasMedico_Click(object sender, EventArgs e)
        {
            Medico medico = listBoxMedicos.SelectedItem as Medico;

            if (medico != null)
            {               
                List<Consultas> consultaDoMedicoSelecionado = _consultasMedicos.Where(c => c.Medico.Id == medico.Id)
                    .ToList();

                ConsultasMedico formConsultasMedico = new ConsultasMedico(consultaDoMedicoSelecionado);
                formConsultasMedico.Show();
            }
            else
            {
                MessageBox.Show("Selecione um médico na lista! ");
            }
        }

        /// <summary>
        /// Filtra os médicos pelo campo selecionado na cmbBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltarMedicos_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxFiltarMedicos.Text.Trim().ToLower(); 

            if (string.IsNullOrWhiteSpace(searchText))
            {
                InitLista(listaMedicos);
                return;
            }

            string filtroSelecionado = cmbFiltrarMedicos.SelectedItem.ToString();

            List<Medico> filteredMedicos = new List<Medico>();

            switch (filtroSelecionado)
            {

                case "Nome":
                    filteredMedicos = listaMedicos.Where(medico => medico.Nome.ToLower().Contains(searchText)).ToList();
                    break;

                case "Apelido":
                    filteredMedicos = listaMedicos.Where(medico => medico.Apelido.ToLower().Contains(searchText)).ToList();
                    break;

                case "Telefone":
                    filteredMedicos = listaMedicos.Where(medico => medico.Telefone.StartsWith(searchText)).ToList();
                    break;

            }
            InitLista(filteredMedicos);
        }

        /// <summary>
        /// Adiciona opções de filtragem à comboBox e estabelece a opção "Nome" como opção default
        /// </summary>
        private void cBoxFiltrarMedicos()
        {
            cmbFiltrarMedicos.Items.Add("Nome");
            cmbFiltrarMedicos.Items.Add("Apelido");
            cmbFiltrarMedicos.Items.Add("Telefone");
            cmbFiltrarMedicos.SelectedIndex = 0;
        }
    }
}
