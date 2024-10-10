using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClinica
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public DateTime DataNascimento { get; set; }
        //public int ClienteId { get; set; }
        public Cliente Dono { get; set; }

        public string IdNome
        {
            get
            {
                return $"ID: {Id} | Nome: {Nome} | Espécie: {Especie}";
            }
        }

      
    }
}
