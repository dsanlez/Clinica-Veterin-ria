using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClinica
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Morada { get; set; }
        public string Telefone { get; set; }
        public string NIF { get; set; }
        public List<Animal> Animais { get; set; } = new List<Animal>();

        public string IdNome
        {
            get
            {
                return $"{Nome} {Apelido} | NIF: {NIF} | Telefone: {Telefone}";
            }
        }

        public string NomeApelidoNIF
        {
            get { return $"{Nome} {Apelido} - {NIF}"; }
        }



    }
}
