using LibraryClinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormVerPets : Form
    {
        private List<Animal> pets;
        private List<Consultas> listaConsultas;

        public FormVerPets(List<Animal> petsDoDono, List<Consultas> listaConsultasMarcadas)
        {
            InitializeComponent();
            pets = petsDoDono;
            listaConsultas = listaConsultasMarcadas;
            AtualizarListaPets();

        }

        /// <summary>
        /// Atualiza a listbox com as consultas do pet selecionado
        /// </summary>
        /// <param name="petId"></param>
        private void AtualizarListaConsultas(int petId)
        {
            var consultasDoPet = listaConsultas.Where(c => c.Animal.Id == petId).ToList();
            listBoxConsultas.Items.Clear();
            foreach (var consulta in consultasDoPet)
            {
                listBoxConsultas.Items.Add($"{consulta.Data:dd/MM/yyyy HH:mm} | {consulta.Especialidade}");
            }
        }

        /// <summary>
        /// Atualizar lista de pets
        /// </summary>
        private void AtualizarListaPets()
        {
            listBoxPets.DataSource = null;
            listBoxPets.DataSource = pets;
            listBoxPets.DisplayMember = "IdNome";
        }

        /// <summary>
        /// Mostra os dados do pet selecionado na listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPets.SelectedItem != null)
            {
                Animal petSelecionado = pets[listBoxPets.SelectedIndex];
                lblIdPet.Text = petSelecionado.Id.ToString();
                lblNomePet.Text = petSelecionado.Nome;
                lblEspeciePet.Text = petSelecionado.Especie;
                lblDataNascimentoPet.Text = petSelecionado.DataNascimento.ToString("dd/MM/yyyy");
                AtualizarListaConsultas(petSelecionado.Id);
            }
        }
    }
}
