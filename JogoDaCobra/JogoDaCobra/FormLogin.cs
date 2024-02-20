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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new();
            inicio.Show();

            Dispose();
            Close();
        }

        private void linkLabelCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearLogin crearLogin = new();
            crearLogin.Show();

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

            textBoxSenha.UseSystemPasswordChar = true;
            linkLabelSenha.Text = "Mostrar";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text.Trim();
            string contrasenaUsuario = textBoxSenha.Text.Trim();

            string validacion = ValidacionesCuenta(nombreUsuario, contrasenaUsuario);
            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion);
                return;
            }

            Utilizador? utilizador = ListaUtilizadores.VerificarYBuscarCuenta(new(nombreUsuario, contrasenaUsuario));
            if (utilizador is null)
            {
                MessageBox.Show("Aquele utilizador não existe ;-;, tente novamente com um utilizador valido");
                return;
            }

            FormJogo formJogo = new(utilizador);
            formJogo.Show();

            Dispose();
            Close();
        }

        private string ValidacionesCuenta(string nombreUsuario, string contrasenaUsuario)
        {
            if (string.IsNullOrEmpty(nombreUsuario))
                return "O campo utilizador se encontra vazio, tente novamente";

            if (!ListaUtilizadores.VerificarNombreUsuario(nombreUsuario))
                return "O utilizador não existe!";

            if (string.IsNullOrEmpty(contrasenaUsuario))
                return "O campo Senha se encontra vazio, tente novamente";

            if (!ListaUtilizadores.VerificarContrasenaUsuario(nombreUsuario, contrasenaUsuario))
                return "A senha é invalida!";

            return string.Empty;
        }
    }
}
