using LibraryClinica;
using System.Runtime.CompilerServices;

namespace FormPrincipal
{
    public class GestãoDeFicheiros
    {
        // Ficheiros Clientes
        /// <summary>
        /// Guardar a info dos clientes
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="origem"></param>
        public static void GuardarClientes(List<Cliente> clientes, string origem)
        {

            // Ficheiro onde os dados dos clientes serão guardados.
            string ficheiroClientes = origem;

            // Cria um StreamWriter para escrever no ficheiro, sobrescrevendo o que lá estava.
            StreamWriter sw = new StreamWriter(ficheiroClientes, false);

            // Verifica se o ficheiro existe. Se não existir, cria um novo.
            if (!File.Exists(ficheiroClientes))
            {
                sw = File.CreateText(ficheiroClientes);
            }

            foreach (Cliente cliente in clientes)
            {
                // Escreve os dados do cliente no ficheiro.
                sw.WriteLine($"{cliente.Id},{cliente.Nome},{cliente.Apelido},{cliente.Morada},{cliente.Telefone},{cliente.NIF}");
            }

            // Fecha o StreamWriter.
            sw.Close();



        }

        /// <summary>
        /// Carregar info dos clientes
        /// </summary>
        /// <param name="animaisCarregados"></param>
        /// <returns></returns>
        public static List<Cliente> AbrirClientes(string origem)
        {
            // Ficheiro de onde serão carregados os dados dos clientes.
            string ficheiro = origem;

            // Cria uma nova lista de clientes.
            List<Cliente> clientes = new List<Cliente>();


            // Verifica se o ficheiro existe.
            if (File.Exists(ficheiro))
            {
                using (StreamReader sr = File.OpenText(ficheiro))
                {

                    string linha = "";

                    // Lê o ficheiro linha por linha.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Instancia um array de strings para armazenar os campos da linha.
                        string[] campos = linha.Split(',');

                        // Cria um novo objeto Cliente e preenche os seus campos básicos.
                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(campos[0]);
                        cliente.Nome = campos[1];
                        cliente.Apelido = campos[2];
                        cliente.Morada = campos[3];
                        cliente.Telefone = campos[4];
                        cliente.NIF = campos[5];
                        cliente.Animais = new List<Animal>();

                        clientes.Add(cliente);
                    }
                    sr.Close();
                }
            }
            return clientes;

        }

        // Ficheiros Animais

        /// <summary>
        /// Guardar Dados Animal
        /// </summary>
        /// <param name="animais"></param>
        /// <param name="origem"></param>
        public static void GuardarAnimais(List<Animal> animais, string origem)
        {

            // Ficheiro onde os dados dos animais serão guardados.
            string ficheiroAnimais = origem;

            // Cria um StreamWriter para escrever no ficheiro, sobrescrevendo o que lá estava.
            using (StreamWriter sw = new StreamWriter(ficheiroAnimais, false))
            {
                foreach (Animal animal in animais)
                {
                    sw.WriteLine($"{animal.Id},{animal.Nome},{animal.Especie},{animal.DataNascimento:yyyy-MM-dd},{animal.Dono.Id}");
                }
            }

        }

        /// <summary>
        /// Carregar dados animais
        /// </summary>
        /// <param name="Donos"></param>
        /// <param name="origem"></param>
        /// <returns></returns>
        public static List<Animal> AbrirAnimais(List<Cliente> Donos, string origem)
        {
            // Ficheiro de onde serão carregados os dados dos clientes.
            string ficheiro = origem;

            // Cria uma nova lista de clientes.
            List<Animal> animais = new List<Animal>();


            // Verifica se o ficheiro existe.
            if (File.Exists(ficheiro))
            {
                using (StreamReader sr = File.OpenText(ficheiro))
                {
                    string linha = "";

                    // Lê o ficheiro linha por linha.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Instancia um array de strings para armazenar os campos da linha.
                        string[] campos = linha.Split(',');

                        // Cria um novo objeto Cliente e preenche os seus campos básicos.
                        Animal pet = new Animal();
                        pet.Id = Convert.ToInt32(campos[0]);
                        pet.Nome = campos[1];
                        pet.Especie = campos[2];
                        pet.DataNascimento = Convert.ToDateTime(campos[3]);
                        Cliente Dono = Donos.FirstOrDefault(d => d.Id == Convert.ToInt32(campos[4]));                       

                        pet.Dono = Dono;

                        Dono.Animais.Add(pet);

                        animais.Add(pet);
                    }
                    sr.Close();
                }
            }
            return animais;

        }

        // Ficheiros Médicos

        /// <summary>
        /// Guardar dados médico
        /// </summary>
        /// <param name="medicos"></param>
        /// <param name="origem"></param>
        public static void GuardarMedicos(List<Medico> medicos, string origem)
        {

            // Ficheiro onde os dados dos médicos serão guardados.
            string ficheiroMedicos = origem;

            // Cria um StreamWriter para escrever no ficheiro, sobrescrevendo o que lá estava.
            StreamWriter sw = new StreamWriter(ficheiroMedicos, false);

            // Verifica se o ficheiro existe. Se não existir, cria um novo.
            if (!File.Exists(ficheiroMedicos))
            {
                sw = File.CreateText(ficheiroMedicos);
            }

            foreach (Medico medico in medicos)
            {
                // Escreve os dados do médico no ficheiro
                sw.WriteLine($"{medico.Id},{medico.Nome},{medico.Apelido},{medico.Especialidade},{medico.Telefone},{medico.Consultorio}");
            }

            // Fecha o StreamWriter.
            sw.Close();


        }

        /// <summary>
        /// Carregar info dos médicos
        /// </summary>
        /// <param name="origem"></param>
        /// <returns></returns>
        public static List<Medico> AbrirMedicos(string origem)
        {
            // Ficheiro de onde serão carregados os dados dos médicos.
            string ficheiro = origem;

            // Cria uma nova lista de médicos.
            List<Medico> medicos = new List<Medico>();


            // Verifica se o ficheiro existe.
            if (File.Exists(ficheiro))
            {
                using (StreamReader sr = File.OpenText(ficheiro))
                {

                    string linha = "";

                    // Lê o ficheiro linha por linha.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Instancia um array de strings para armazenar os campos da linha.
                        string[] campos = linha.Split(',');

                        // Cria um novo objeto Medico e preenche os seus campos básicos.
                        Medico medico = new Medico();
                        medico.Id = Convert.ToInt32(campos[0]);
                        medico.Nome = campos[1];
                        medico.Apelido = campos[2];
                        medico.Especialidade = campos[3];
                        medico.Telefone = campos[4];
                        medico.Consultorio = Convert.ToInt32(campos[5]);

                        medicos.Add(medico);
                    }
                    sr.Close();
                }
            }
            return medicos;

        }

        //Ficheiros consultas
        /// <summary>
        /// Guardar dados das consultas
        /// </summary>
        /// <param name="consultas"></param>
        /// <param name="origem"></param>
        public static void GuardarConsultas(List<Consultas> consultas, string origem)
        {

            // Ficheiro onde os dados dos médicos serão guardados.
            string ficheiroConsultas = origem;

            // Cria um StreamWriter para escrever no ficheiro, sobrescrevendo o que lá estava.
            StreamWriter sw = new StreamWriter(ficheiroConsultas, false);


            if (!File.Exists(ficheiroConsultas))
            {
                sw = File.CreateText(ficheiroConsultas);
            }

            foreach (Consultas consulta in consultas)
            {
                sw.WriteLine($"{consulta.Id},{consulta.Animal.Id},{consulta.Medico.Id},{consulta.Data},{consulta.Especialidade}");
            }
            sw.Close();
        }

        /// <summary>
        /// Fichero para carregar os dados das consultas
        /// </summary>
        /// <param name="origem"></param>
        /// <returns></returns>
        public static List<Consultas> CarregarConsultas(string origem, List<Animal> listaAnimais, List<Medico> listaMedicos)
        {
            // Ficheiro de onde serão carregados os dados dos médicos.
            string ficheiro = origem;

            // Cria uma nova lista de médicos.
            List<Consultas> consultas = new List<Consultas>();


            // Verifica se o ficheiro existe.
            if (File.Exists(ficheiro))
            {
                using (StreamReader sr = File.OpenText(ficheiro))
                {
                    string linha = "";

                    // Lê o ficheiro linha por linha.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Instancia um array de strings para armazenar os campos da linha.
                        string[] campos = linha.Split(',');

                        // Cria um novo objeto Medico e preenche os seus campos básicos.
                        Consultas consulta = new Consultas();
                        consulta.Id = Convert.ToInt32(campos[0]);

                        int animalId = Convert.ToInt32(campos[1]);
                        Animal animal = listaAnimais.FirstOrDefault(a => a.Id == animalId);
                        if (animal != null)
                        {
                            consulta.Animal = animal;
                        }
                        else
                        {
                            throw new InvalidOperationException($"Animal com ID {animalId} não encontrado.");
                        }

                        int medicoId = Convert.ToInt32(campos[2]);

                        Medico medico = listaMedicos.FirstOrDefault(m => m.Id == medicoId);
                        if (medico != null)
                        {
                            consulta.Medico = medico;
                        }
                        else
                        {

                            throw new InvalidOperationException($"Médico com ID {medicoId} não encontrado.");
                        }
                        consulta.Data = Convert.ToDateTime(campos[3]);

                        consulta.Especialidade = campos[4];

                        consultas.Add(consulta);
                    }
                    sr.Close();
                }
            }
            return consultas;
        }

        /// <summary>
        /// Grava os dados de registo de login dos users
        /// </summary>
        /// <param name="utilizadores"></param>
        /// <param name="origem"></param>
        public static void GuardarUtilizadores(List<Utilizador> utilizadores, string origem)
        {
            string ficheiroUtilizadores = origem;

            // Cria um StreamWriter para escrever no ficheiro, sobrescrevendo o que lá estava.
            StreamWriter sw = new StreamWriter(ficheiroUtilizadores, false);


            if (!File.Exists(ficheiroUtilizadores))
            {
                sw = File.CreateText(ficheiroUtilizadores);
            }

            foreach (Utilizador utilizador in utilizadores)
            {
                sw.WriteLine($"{utilizador.username},{utilizador.password}");
            }
            sw.Close();
        }

        /// <summary>
        /// Carrega os dados dos utilizadores
        /// </summary>
        /// <param name="origem"></param>
        /// <returns></returns>
        public static List<Utilizador> CarregarUtilizadores(string origem)
        {
            // Ficheiro de onde serão carregados os dados dos médicos.
            string ficheiro = origem;

            // Cria uma nova lista de médicos.
            List<Utilizador> utilizadores = new List<Utilizador>();


            // Verifica se o ficheiro existe.
            if (File.Exists(ficheiro))
            {
                using (StreamReader sr = File.OpenText(ficheiro))
                {
                    string linha = "";

                    // Lê o ficheiro linha por linha.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Instancia um array de strings para armazenar os campos da linha.
                        string[] campos = linha.Split(',');

                        // Cria um novo objeto Medico e preenche os seus campos básicos.
                        Utilizador utilizador = new Utilizador();
                        utilizador.username = campos[0];
                        utilizador.password = campos[1];


                        utilizadores.Add(utilizador);
                    }
                    sr.Close();
                }
            }
            return utilizadores;
        }
    }
    
}


