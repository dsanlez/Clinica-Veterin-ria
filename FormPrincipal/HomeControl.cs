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
    public partial class HomeControl : UserControl
    {
        private List<Medico> _medicoList;
        private List<Cliente> _clienteList;
        private List<Animal> _animalList;
        private List<Consultas> _consultasList;
        public HomeControl(List<Medico> medicosRegistados, List<Cliente> clientesRegistados, List<Animal> petsRegistados, List<Consultas> consultasRegistados)
        {
            InitializeComponent();
            _medicoList = medicosRegistados;
            _animalList = petsRegistados;
            _clienteList = clientesRegistados;
            _consultasList = consultasRegistados;
            lblNmrMedicos.Text = "Médicos na Clínica:  " + medicosRegistados.Count.ToString();
            lblNmrAnimais.Text = "Animais Registados:  " + petsRegistados.Count.ToString();
            lblNmrClientes.Text = "Clientes Registados:  " + clientesRegistados.Count.ToString();
            lblNmrConsultas.Text = "Consultas Marcadas:  " + consultasRegistados.Count.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
