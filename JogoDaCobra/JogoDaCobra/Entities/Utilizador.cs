using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JogoDaCobra.Entities
{
    public class Utilizador
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public int Level { get; set; }
        public int Score { get; set; }

        [JsonConstructor]
        public Utilizador(string username, string password)
        {
            Username = username;
            Password = password;
            Level = 1;
            Score = 0;
        }

        public Utilizador(Utilizador utilizador)
        {
            Username = utilizador.Username;
            Password = utilizador.Password;
            Level = 1;
            Score = 0;
        }

        public void GuardarPuntuacion(int level, int score)
        {
            if(score > Score) 
                Score = score;

            if (level > Level)
                Level = level;
        }
    }
}
