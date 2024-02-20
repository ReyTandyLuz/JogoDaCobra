using JogoDaCobra.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaCobra
{
    public partial class CrearLogin : Form
    {
        public CrearLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new();
            formLogin.Show();

            Dispose();
            Close();
        }

        private void linkLabelSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelSenha.Text == "Mostrar")
            {
                textBoxSenha.UseSystemPasswordChar = false;
                linkLabelSenha.Text = "Ocultar";
                return;
            }
        }

        private void linkLabelConfirmarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelConfirmarSenha.Text == "Mostrar")
            {
                textBoxSenha.UseSystemPasswordChar = false;
                linkLabelSenha.Text = "Ocultar";
                return;
            }
        }

        private async void buttonCriar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text.Trim();
            string senhaUsuario = textBoxSenha.Text.Trim();
            string confirmarSenhaUsuario = textBoxConfirmarSenha.Text.Trim();

            string validacion = ValidacionesCuenta(nombreUsuario, senhaUsuario, confirmarSenhaUsuario);
            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion);
                return;
            }

            Utilizador? utilizador = new(nombreUsuario, senhaUsuario);
            if (ListaUtilizadores.AdicionarJogador(utilizador))
            {
                MessageBox.Show("Aquela conta já existe");
                return;
            }

            utilizador = ListaUtilizadores.VerificarYBuscarCuenta(utilizador);
            if (utilizador is null)
            {
                MessageBox.Show("Aconteceu um erro com a conta criada, tente cria-la novamente por favor");
                return;
            }

            MessageBox.Show($"Bem-vindo {utilizador.Username}, a tua conta foi criada com sucesso :D");

            FormJogo formJogo = new(utilizador);
            formJogo.Show();

            Dispose();
            Close();

        }

        private string ValidacionesCuenta(string nombreUsuario, string senhaUsuario, string confirmarSenhaUsuario)
        {
            if (string.IsNullOrEmpty(nombreUsuario))
                return "O campo utilizador se encontra vazio, tente novamente";

            else if (string.IsNullOrEmpty(senhaUsuario))
                return "O campo Senha se encontra vazio, tente novamente";

            else if (string.IsNullOrEmpty(confirmarSenhaUsuario))
                return "O campo confirmar senha se encontra vazio, tente novamente";

            else if (senhaUsuario != confirmarSenhaUsuario)
                return "As senhas não coincidem, tente novamente";

            return string.Empty;
        }
    }
}
