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
    public partial class DadosDono : Form
    {
        private Cliente dono;
        public DadosDono(Cliente donoSelecionado)
        {
            InitializeComponent();
            dono = donoSelecionado;
            MostarDadosDono();
        }

        private void MostarDadosDono()
        {
            lblNomeValor.Text = dono.Nome;
            lblMoradaValor.Text = dono.Morada;
            lblTelefoneValor.Text = dono.Telefone;
            lblNifValor.Text = dono.NIF;
            lblIDValor.Text = dono.Id.ToString();
        }
    }
}
