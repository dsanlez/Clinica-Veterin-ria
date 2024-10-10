using LibraryClinica;
using System.Data;


namespace FormPrincipal
{
    public partial class ConsultasControl : UserControl
    {
        private List<Consultas> _listaConsultas;
        private List<Animal> _listaAnimais;
        private List<Medico> _listaMedicos;
        private List<Cliente> _listaClientes;

        private static int _nextConsultaId = 1;

        public ConsultasControl(List<Consultas> consultas, List<Animal> animais, List<Medico> medicos, int nextCosultaId, List<Cliente> clientes)
        {
            InitializeComponent();
            _listaConsultas = consultas;
            _listaAnimais = animais;
            _listaMedicos = medicos;
            _listaClientes = clientes;

            InitLista();
            InitComboBoxes();

            monthCalendarConsultas.DateChanged += ConsultasDoMes_DateChanged;
            lblConsultório.Text = "Consultório: ";

            _nextConsultaId = nextCosultaId;
            textBoxIdConsulta.Text = nextCosultaId.ToString();

            listBoxConsultas.SelectedItem = null;
            LimparCampos();
        }

        /// <summary>
        /// Carrega os dados das comboBox
        /// </summary>
        private void InitComboBoxes()
        {
            comboBoxMedico.DataSource = _listaMedicos;
            comboBoxMedico.DisplayMember = "Nome";
            comboBoxMedico.ValueMember = "Id";

            comboBoxDono.DataSource = _listaClientes;
            comboBoxDono.DisplayMember = "Nome";
            comboBoxDono.ValueMember = "Id";

            if (comboBoxDono.SelectedItem != null)
            {
                comboBoxAnimal.DataSource = _listaAnimais.Where(a => a.Dono.Equals(comboBoxDono.SelectedItem)).ToList();
                comboBoxAnimal.DisplayMember = "Nome";
                comboBoxAnimal.ValueMember = "Id";
            }
            else
            {
                comboBoxAnimal.DataSource = null;
            }
        }

        /// <summary>
        /// Iniciar/Atualizar Lista de consultas na data atual
        /// </summary>
        private void InitLista()
        {
            listBoxConsultas.DataSource = null;
            listBoxConsultas.DataSource = _listaConsultas.Where(c => c.Data.Date == monthCalendarConsultas.SelectionStart.Date).ToList();
            listBoxConsultas.DisplayMember = "DadosConsulta";

        }

        /// <summary>
        /// Validar Campos
        /// </summary>
        /// <returns></returns>
        private bool ValidarDadosConsulta()
        {
            if (comboBoxAnimal.SelectedItem == null)
            {
                MessageBox.Show("Selecione um animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxMedico.SelectedItem == null)
            {
                MessageBox.Show("Selecione um médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEspecialidade.Text))
            {
                MessageBox.Show("Insira a especialidade da consulta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string pattern = @"^[a-zA-Z\s]+$";

            // Verifica se o nome contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEspecialidade.Text, pattern))
            {
                MessageBox.Show("A especidalidade de consulta não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DateTime dataConsulta = monthCalendarConsultas.SelectionStart.Date
                                .AddHours((double)numericUpDownHoras.Value)
                                .AddMinutes((double)numericUpDownMinutos.Value);

            if (dataConsulta < DateTime.Now)
            {
                MessageBox.Show("Não pode ser agendada consulta nessa data/hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Limpa os campos
        /// </summary>
        private void LimparCampos()
        {
            comboBoxAnimal.SelectedIndex = -1;
            comboBoxMedico.SelectedIndex = -1;
            comboBoxDono.SelectedIndex = -1;
            numericUpDownMinutos.Value = 0;
            numericUpDownHoras.Value = 8;
            textBoxEspecialidade.Clear();
            lblConsultório.Text = "Consultório: ";
        }

        /// <summary>
        /// Registar Consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistarConsulta_Click(object sender, EventArgs e)
        {
            if (ValidarDadosConsulta())
            {
                DateTime dataCalendario = monthCalendarConsultas.SelectionStart.Date;

                // Obtém as horas e minutos selecionados nos NumericUpDowns
                int horaNumeric = (int)numericUpDownHoras.Value;
                int minutoNumeric = (int)numericUpDownMinutos.Value;

                // Combina a data, horas e minutos num novo DateTime
                DateTime dataCompleta = new DateTime(
                    dataCalendario.Year,
                    dataCalendario.Month,
                    dataCalendario.Day,
                    horaNumeric,
                    minutoNumeric,
                    0
                    );

                // Verifica se o médico está disponível
                if (!MedicoDisponivel((int)comboBoxMedico.SelectedValue, dataCompleta))
                {
                    MessageBox.Show("O médico selecionado já tem uma consulta agendada dentro desse horário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Consultas consulta = new Consultas
                {
                    Id = _nextConsultaId,
                    Animal = comboBoxAnimal.SelectedItem as Animal,
                    Medico = comboBoxMedico.SelectedItem as Medico,
                    Data = dataCompleta,
                    Duracao = TimeSpan.FromMinutes(30),
                    Especialidade = textBoxEspecialidade.Text
                };

                _listaConsultas.Add(consulta);
                _nextConsultaId++;
                InitLista();
                LimparCampos();
                listBoxConsultas.SelectedItem = null;

                textBoxIdConsulta.Text = _nextConsultaId.ToString();
            }
        }

        /// <summary>
        /// Editar consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultaSelecionada = _listaConsultas.FirstOrDefault(c => c.Id == Convert.ToInt32(textBoxIdConsulta.Text));
            if (consultaSelecionada == null)
            {
                MessageBox.Show("Selecione uma consulta");
                return;
            }

            if (ValidarDadosConsulta())
            {
                DateTime dataCalendario = monthCalendarConsultas.SelectionStart.Date;

                // Obtém as horas e minutos selecionados nos NumericUpDowns
                int horaNumeric = (int)numericUpDownHoras.Value;
                int minutoNumeric = (int)numericUpDownMinutos.Value;

                // Combina a data, horas e minutos num novo DateTime
                DateTime dataCompleta = new DateTime(
                    dataCalendario.Year,
                    dataCalendario.Month,
                    dataCalendario.Day,
                    horaNumeric,
                    minutoNumeric,
                    0
                    );

                bool consultaAlterada = false;

                // Verifica se houve alterações nos dados do animal
                if (consultaSelecionada.Animal != comboBoxAnimal.SelectedItem as Animal ||
                    consultaSelecionada.Medico != comboBoxMedico.SelectedItem as Medico ||
                    consultaSelecionada.Data != dataCompleta ||
                    consultaSelecionada.Especialidade != textBoxEspecialidade.Text)
                {
                    consultaSelecionada.Animal = comboBoxAnimal.SelectedItem as Animal;
                    consultaSelecionada.Medico = comboBoxMedico.SelectedItem as Medico;
                    consultaSelecionada.Data = dataCompleta;
                    consultaSelecionada.Especialidade = textBoxEspecialidade.Text;
                    consultaAlterada = true;
                }

                if (consultaAlterada)
                {
                    MessageBox.Show("Consulta editada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                InitLista();
                listBoxConsultas.SelectedItem = null;
                LimparCampos();
            }
        }

        /// <summary>
        /// Apaga consultas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApagarConsulta_Click(object sender, EventArgs e)
        {
            if (listBoxConsultas.SelectedItem != null)
            {
                Consultas consultaParaRemover = listBoxConsultas.SelectedItem as Consultas;

                if (consultaParaRemover != null)
                {
                    DialogResult resposta = MessageBox.Show($"Tem certeza que deseja remover a consulta {consultaParaRemover.Id}?", "Remover", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (resposta == DialogResult.OK)
                    {
                        _listaConsultas.Remove(consultaParaRemover);
                        InitLista();
                    }
                }
            }
        }

        /// <summary>
        /// Mostra no dia selecionado no calendário as consultas marcadas, se houver alguma 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultasDoMes_DateChanged(object sender, DateRangeEventArgs e)
        {                       

            // Obtém a data selecionada no controle MonthCalendar, ignorando a hora.
            var selectedDate = monthCalendarConsultas.SelectionStart.Date;

            // Filtra a lista de consultas para obter apenas aquelas que ocorrem na data selecionada.            
            var consultasDoDia = _listaConsultas.Where(c => c.Data.Date == selectedDate).ToList();

            // Verifica se há consultas para exibir
            if (consultasDoDia.Any())
            {
                listBoxConsultas.DataSource = null;
                listBoxConsultas.DataSource = consultasDoDia;
                listBoxConsultas.DisplayMember = "dadosConsulta";
            }
            else
            {
                listBoxConsultas.DataSource = null;
                listBoxConsultas.Items.Clear();
                listBoxConsultas.Items.Add("Não existem consultas");
            }
            listBoxConsultas.SelectedItem = null;
           
        }

        /// <summary>
        /// Mostra a informação consulta selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (listBoxConsultas.SelectedItem != null)
            {
                Consultas consultaSelecionada = listBoxConsultas.SelectedItem as Consultas;

                if (consultaSelecionada != null)
                {
                    textBoxIdConsulta.Text = consultaSelecionada.Id.ToString();
                    comboBoxAnimal.SelectedItem = consultaSelecionada.Animal;
                    comboBoxMedico.SelectedItem = consultaSelecionada.Medico;
                    comboBoxDono.SelectedItem = consultaSelecionada.Animal.Dono;

                    numericUpDownMinutos.Value = consultaSelecionada.Data.Minute;
                    numericUpDownHoras.Value = consultaSelecionada.Data.Hour;
                    textBoxEspecialidade.Text = consultaSelecionada.Especialidade;

                    // Atualiza a lblConsultório com base no médico selecionado
                    Medico medico = comboBoxMedico.SelectedItem as Medico;
                    if (medico != null)
                    {
                        lblConsultório.Text = "Consultório:  " + medico.Consultorio.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Verifica se o médico selecionado está disponível para dar consulta.
        /// </summary>
        /// <param name="medicoId"></param>
        /// <param name="dataConsulta"></param>
        /// <returns></returns>
        private bool MedicoDisponivel(int medicoId, DateTime dataConsulta)
        {
            TimeSpan duracaoConsulta = TimeSpan.FromMinutes(30); // Duração padrão de 30 minutos

            foreach (var consulta in _listaConsultas)
            {
                // Verifica se o médico da consulta existente é o mesmo que o médico da nova consulta
                if (consulta.Medico != null && consulta.Medico.Id == medicoId)
                {

                    // Verifica sobreposição de tempo                    
                    // Verifica se a hora da nova consulta ocorre durante a hora da consulta existente.
                    if (dataConsulta < consulta.Data.Add(consulta.Duracao) &&
                        // Verifica se a consulta existente começa antes da nova consulta que está a ser agendada acabar.
                        consulta.Data < dataConsulta.Add(duracaoConsulta))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Ao selecionar um dono, é exibido na cmb dos animais, a lista dos animais do dono selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDono.SelectedItem != null)
            {
                var animaisFiltrados = _listaAnimais.Where(a => a.Dono.Equals(comboBoxDono.SelectedItem)).ToList();

                if (animaisFiltrados.Count > 0)
                {
                    comboBoxAnimal.DataSource = animaisFiltrados;
                    comboBoxAnimal.DisplayMember = "Nome";
                    comboBoxAnimal.ValueMember = "Id";
                }
                else
                {
                    // Limpar a comboBoxAnimal se não houver animais associados
                    comboBoxAnimal.DataSource = null;
                    comboBoxAnimal.Items.Clear();
                }
            }            
        }

        /// <summary>
        /// Atribui a label o consultorio do medico selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMedico.SelectedItem != null)
            {
                lblConsultório.Text = "Consultório:  " + (comboBoxMedico.SelectedItem as Medico).Consultorio.ToString();
            }
            
        }
    }
}
