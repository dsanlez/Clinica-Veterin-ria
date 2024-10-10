using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClinica
{
    public class Medico
    {
        private int _consultorio;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Especialidade { get; set; }
        public string Telefone { get; set; }
        public int Consultorio
        {
            get { return _consultorio; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("O número do consultório deve ser >= 1");

                }
                else
                {
                    _consultorio = value;
                }
            }
        }
        public string IdNome
        {
            get
            {
                return $"{Nome} {Apelido} | Telefone: {Telefone}";
            }
        }                   
    }

}

