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
    public partial class ConsultasMedico : Form
    {
        private List<Consultas> _consultas;
        public ConsultasMedico(List<Consultas> consultas)
        {
            InitializeComponent();
            _consultas = consultas;
            listBoxConsultas.DataSource = consultas;
            listBoxConsultas.DisplayMember = "DadosConsultaMedico";
        }
    }
}
