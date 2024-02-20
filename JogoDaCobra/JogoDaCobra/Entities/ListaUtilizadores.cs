using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobra.Entities
{
    internal static class ListaUtilizadores
    {
        public static List<Utilizador> Utilizadores { get; set; } = new();
        private const string JsonFilePath = "fjsjc.json";

        public static bool AdicionarJogador(Utilizador utilizador)
        {
            if(Utilizadores.Any(j => j.Username == utilizador.Username))
            {
                MessageBox.Show($"Sentimô-lo mas o utilizador \"{utilizador.Username}\" já existe!!");
                return true;
            }

            Utilizadores.Add(new(utilizador));
            return false;

        }

        public static async void AtualizarDador(string user, byte level, int pontos)
        {
            Utilizador? jogadorActual = Utilizadores.FirstOrDefault(j => j.Username == user);
            if(jogadorActual is null)
            {
                MessageBox.Show("Uy! O jogador não foi encontrado ._.");
                return;
            }

            jogadorActual.Level = level;
            jogadorActual.Score = pontos;

            MessageBox.Show($"Dados de {jogadorActual.Username} atualizados com sucesso!!!");

            await GuardarDatos();
        }

        public static async Task CarregarDados()
        {
            try
            {
                using (FileStream fileStream = File.Open(JsonFilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string fileContent = await reader.ReadToEndAsync();

                    if (string.IsNullOrEmpty(fileContent))
                    {
                        Utilizadores = [];
                        return;
                    }

                    Utilizadores = JsonConvert.DeserializeObject<List<Utilizador>>(fileContent) ?? [];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro lendo: {ex.Message}");
            }
        }

        public static async Task GuardarDatos()
        {
            using StreamWriter sw = new(JsonFilePath);

            string json = JsonConvert.SerializeObject(Utilizadores);
            await sw.WriteLineAsync(json);
        }

        internal static Utilizador? VerificarYBuscarCuenta(Utilizador utilizador)
        {
            return Utilizadores.Find(usuario => usuario.Username == utilizador.Username && usuario.Password == utilizador.Password);
        }


        internal static bool VerificarNombreUsuario(Utilizador utilizador)
        {
            return Utilizadores.Any(usuario => usuario.Username == utilizador.Username);
        }

        internal static bool VerificarNombreUsuario(string nombreUsuario)
        {
            return Utilizadores.Any(usuario => usuario.Username == nombreUsuario);
        }


        internal static bool VerificarContrasenaUsuario(Utilizador utilizador)
        {
            return Utilizadores.Any(usuario => usuario.Username == utilizador.Username && usuario.Password == utilizador.Password);
        }

        internal static bool VerificarContrasenaUsuario(string usuarioNome, string contrasena)
        {
            return Utilizadores.Any(usuario => usuario.Username == usuarioNome && usuario.Password == contrasena);
        }


        internal static bool VerificarUsuarioExistente(Utilizador utilizador)
        {
            if (Utilizadores.Any(usuario => usuario.Username == utilizador.Username && usuario.Password == utilizador.Password))
                return true;

            return false;
        }
    }
}
