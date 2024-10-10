using LibraryClinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class AnimalControl : UserControl
    {
        private List<Cliente> listaClientes;
        private List<Animal> listaAnimais;
        private static int _nextAnimalId = 1;
        private List<Consultas> listaConsultasPet;
        public AnimalControl(List<Cliente> clientes, List<Animal> NovalistaAnimais, List<Consultas> consultas, int nextPetId)
        {
            InitializeComponent();
            listaClientes = clientes;
            listaAnimais = NovalistaAnimais;
            listaConsultasPet = consultas;

            LoadClientes();
            InitLista(listaAnimais);
            cBoxFiltrarAnimais();

            listBoxPets.SelectedItem = null;
            _nextAnimalId = nextPetId;
            textBoxIdPet.Text = nextPetId.ToString();

            LimparCampos();
        }

        /// <summary>
        /// Carrega os clientes para a comboBox
        /// </summary>
        private void LoadClientes()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = listaClientes;
            cmbCliente.DisplayMember = "NomeApelidoNIF";
            cmbCliente.ValueMember = "Id";
        }

        /// <summary>
        /// Cria um pet e adiciona o às listas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovoPet_Click(object sender, EventArgs e)
        {
            if (ValidarDadosAnimal())
            {

                Cliente donoSelecionado = cmbCliente.SelectedItem as Cliente;

                if (donoSelecionado == null)
                {
                    MessageBox.Show("Por favor, selecione um dono para o animal.");
                    return;
                }

                Animal animal = new Animal
                {
                    Id = _nextAnimalId,
                    Nome = textBoxNomePet.Text,
                    Especie = textBoxEspecie.Text,
                    DataNascimento = dateTimePickerDataNascimento.Value,
                    Dono = donoSelecionado
                };

                _nextAnimalId++;
                listaAnimais.Add(animal);
                donoSelecionado.Animais.Add(animal);

                textBoxIdPet.Text = _nextAnimalId.ToString();

                listBoxPets.SelectedItem = null;
                InitLista(listaAnimais);
                LimparCampos();
            }
        }

        /// <summary>
        /// Atualiza a listBox
        /// </summary>
        public void InitLista(List<Animal> listaAnimais)
        {
            listBoxPets.DataSource = null;
            listBoxPets.DataSource = listaAnimais;
            listBoxPets.DisplayMember = "IdNome";
        }

        /// <summary>
        /// Limpas caixas de texto
        /// </summary>
        private void LimparCampos()
        {
            textBoxNomePet.Text = string.Empty;
            textBoxEspecie.Text = string.Empty;
            dateTimePickerDataNascimento.Value = DateTime.Now;
            cmbCliente.SelectedIndex = -1;
        }

        /// <summary>
        /// Remove o animal da lista da animais e da lista de animais do Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApagarPet_Click(object sender, EventArgs e)
        {
            Animal? animalSelecionado = listBoxPets.SelectedItem as Animal;

            Animal? animalParaApagar = null;

            if (animalSelecionado != null)
            {
                foreach (Animal animal in listaAnimais)
                {
                    if (animalSelecionado.Id == animal.Id)
                    {
                        animalParaApagar = animal;
                        break;
                    }
                }

                if (animalParaApagar != null)
                {
                    DialogResult resposta = MessageBox.Show($"Tem a certeza que quer apagar o {animalParaApagar.Nome}?",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        Cliente dono = animalParaApagar.Dono;
                        if (dono != null)
                        {
                            ///Remove o animal das lista de Pets do dono
                            dono.Animais.Remove(animalParaApagar);
                        }
                        ///Remove o pet da lista de animais
                        listaAnimais.Remove(animalParaApagar);

                        ///Apaga as consultas em que o pet estava registado
                        listaConsultasPet.RemoveAll(c => c.Animal.Id == animalParaApagar.Id);

                        InitLista(listaAnimais);
                        LimparCampos();
                    }
                }
            }
        }

        /// <summary>
        /// Editar e Atualizar os dados do pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarPet_Click(object sender, EventArgs e)
        {
            if (listBoxPets.SelectedItem != null && ValidarDadosAnimal())
            {
                Animal animalSelecionado = listBoxPets.SelectedItem as Animal;

                if (animalSelecionado != null)
                {
                    bool animalAlterado = false;

                    if (animalSelecionado.Nome != textBoxNomePet.Text ||
                        animalSelecionado.Especie != textBoxEspecie.Text ||
                        animalSelecionado.DataNascimento != dateTimePickerDataNascimento.Value ||
                        animalSelecionado.Dono.Id != (int)cmbCliente.SelectedValue)
                    {
                        animalSelecionado.Nome = textBoxNomePet.Text;
                        animalSelecionado.Especie = textBoxEspecie.Text;
                        animalSelecionado.DataNascimento = dateTimePickerDataNascimento.Value;

                        // Atualiza o dono do animal com o valor selecionado no ComboBox

                        int clienteIdSelecionado = (int)cmbCliente.SelectedValue;
                        Cliente clienteSelecionado = listaClientes.FirstOrDefault(c => c.Id == clienteIdSelecionado);
                        animalSelecionado.Dono = clienteSelecionado;
                        animalAlterado = true;
                    }

                    if (animalAlterado)
                    {
                        MessageBox.Show("Animal editado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração feita.");
                    }

                   
                    InitLista(listaAnimais);
                    listBoxPets.SelectedItem = null;
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um animal na lista! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// validação de dados de entrada
        /// </summary>
        /// <returns></returns>
        ///
        private bool ValidarDadosAnimal()
        {
            if (string.IsNullOrWhiteSpace(textBoxNomePet.Text))
            {
                MessageBox.Show("Insira o nome do animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string pattern = @"^[a-zA-Z\s]+$";

            // Verifica se o nome contém apenas letras e espaços
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxNomePet.Text, pattern))
            {
                MessageBox.Show("O nome do animal não pode conter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEspecie.Text))
            {
                MessageBox.Show("Insira a espécie do animal!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxEspecie.Text.All(char.IsDigit) || !System.Text.RegularExpressions.Regex.IsMatch(textBoxEspecie.Text, pattern))
            {
                MessageBox.Show("A espécie do animal não deve conter digitos ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            DateTime dataNascimento = dateTimePickerDataNascimento.Value;
            if (dataNascimento > DateTime.Now)
            {
                MessageBox.Show("Insira uma data válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;


        }

        /// <summary>
        /// Mostra os dados do pet quando selecionado na listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPets_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxPets.SelectedItem != null)
            {
                Animal animalSelecionado = listBoxPets.SelectedItem as Animal;

                if (animalSelecionado != null)
                {
                    // Preenche as TextBoxes com os dados do animal selecionado
                    textBoxIdPet.Text = animalSelecionado.Id.ToString();
                    textBoxNomePet.Text = animalSelecionado.Nome;
                    textBoxEspecie.Text = animalSelecionado.Especie;
                    dateTimePickerDataNascimento.Value = animalSelecionado.DataNascimento;

                    // Encontra o cliente dono do animal e seleciona no ComboBox
                    Cliente dono = animalSelecionado.Dono;
                    if (dono != null)
                    {
                        cmbCliente.SelectedItem = dono;
                    }
                    else
                    {
                        cmbCliente.SelectedIndex = -1; // Nenhum dono encontrado.
                    }
                }
            }
        }

        /// <summary>
        /// Filtra a listBox dos animais pelo ID do Pet ou pelo Nif do dono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrarPets_TextChanged(object sender, EventArgs e)
        {

            string searchText = textBoxFiltrarPets.Text.Trim().ToLower();

            // Se a barra de pesquisa estiver vazia, mostrar todos os animais
            if (string.IsNullOrWhiteSpace(searchText))
            {
                InitLista(listaAnimais);
                return;
            }

            List<Animal> filteredAnimals = new List<Animal>();

            switch (cmbFiltrarAnimais.SelectedItem.ToString())
            {
                case "ID":
                    if (int.TryParse(searchText, out int id))
                    {
                        filteredAnimals = listaAnimais.Where(animal => animal.Id == id).ToList();
                    }
                    break;

                case "Nome":
                    filteredAnimals = listaAnimais.Where(animal => animal.Nome.ToLower().Contains(searchText)).ToList();
                    break;

                case "NIF":
                    filteredAnimals = listaAnimais.Where(animal => animal.Dono.NIF.ToLower().StartsWith(searchText)).ToList();
                    break;
            }

            InitLista(filteredAnimals);
        }

        /// <summary>
        /// Abrir Forms com os dados do dono do pet ou dono selecionado na CB durante o registo do pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDadosDono_Click(object sender, EventArgs e)
        {
            Cliente donoSelecionado = cmbCliente.SelectedItem as Cliente;
            if (donoSelecionado != null)
            {
                DadosDono formDono = new DadosDono(donoSelecionado);
                formDono.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um dono.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Adiciona opções de filtragem à comboBox e estabelece a opção "ID" como opção default
        /// </summary>
        private void cBoxFiltrarAnimais()
        {
            cmbFiltrarAnimais.Items.Add("ID");
            cmbFiltrarAnimais.Items.Add("Nome");
            cmbFiltrarAnimais.Items.Add("NIF");
            
            cmbFiltrarAnimais.SelectedIndex = 0;

        }
    }
}

