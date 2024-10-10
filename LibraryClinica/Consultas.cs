using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClinica
{
    public class Consultas
    {
        public int Id { get; set; }
        public Animal Animal { get; set; } 
        public Medico Medico { get; set; }  
        public DateTime Data { get; set; }
        public string Especialidade { get; set;}
        public TimeSpan Duracao { get; set; } = TimeSpan.FromMinutes(30);

        

        public string DadosConsulta
        {
            get
            {
                return $"Data: {Data:M} {Data:HH:mm} | Dono:{Animal.Dono.Nome} | Animal: {Animal.Nome} | Espécie: {Animal.Especie} | Médico: {Medico.Nome} | {Especialidade}";
            }
        }

        public string DadosConsultaMedico
        {
            get
            {
                return $"Data: {Data:M} {Data:HH:mm} | Animal: {Animal.Nome} | Espécie: {Animal.Especie}| {Especialidade}";
            }
        }
    }
}
