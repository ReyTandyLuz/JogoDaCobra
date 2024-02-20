using JogoDaCobra.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace JogoDaCobra
{
    public partial class FormJogo : Form
    {
        private Utilizador Utilizador { get; set; }

        private Comida Comida;
        private Cobra Cobra;

        public FormJogo(Utilizador utilizador)
        {
            InitializeComponent();
            Utilizador = utilizador;
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            Comida = new();
            Cobra = new();
            ClientSize = new Size(Inf.SIZE_WIDTH, Inf.SIZE_WIDTH);

            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            BackColor = Color.DarkGreen;
            Text = "Jogo da cobra juego";

            Inf.Nivel = 1;
            Inf.Pontos = 0;
            Inf.UtilizadorActual = Utilizador;

            TslJogador.Text = Utilizador.Username;
        }

        private void Jogo_Paint(object sender, PaintEventArgs e)
        {
            Comida.Draw(e.Graphics);
            Cobra.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cobra.Mover();
            VerificarColisao();
            ActualizarInf();
            Invalidate();
        }

        private void ActualizarInf()
        {
            TslPontos.Text = Inf.Pontos.ToString();
            TslNivel.Text = Inf.Nivel.ToString();
        }

        private void Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            Cobra.HandleKeyPress(e.KeyCode);
            Invalidate();
        }

        private void VerificarColisao()
        {
            if (Math.Abs(Cobra.Cabeca.X - Comida.Posicion.X) <= 20 && Math.Abs(Cobra.Cabeca.Y - Comida.Posicion.Y) <= 20)
            {
                Cobra.Grow();
                Cobra.AumentarPontuacao();

                if (Inf.Pontos % 50 == 0)
                {
                    Inf.Nivel++;
                    timer1.Interval -= 10;
                }

                Comida.GerarNovaPosicao();
            }

            if (Cobra.VerificarColicaoFronteira() || Cobra.VerificarColicaoPropria())
                FimJogo();

        }

        private async void FimJogo()
        {
            timer1.Stop();

            Inf.UtilizadorActual.GuardarPuntuacion(Inf.Nivel, Inf.Pontos);
            await ListaUtilizadores.GuardarDatos();

            MessageBox.Show($@"
Sinceramente, todos estamos muito decepcionados de ti .-. 

Melhor Pontoação: {Inf.UtilizadorActual.Score}
Pontoação:    {TslPontos}

Melhor nível: {Inf.UtilizadorActual.Level}
Nível: {Inf.Nivel}");
        }

        private void Jogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 && timer1.Enabled == false)
                timer1.Start();
            else if (e.KeyChar == 32 && timer1.Enabled == true)
                timer1.Stop();

            if (e.KeyChar == 13)
                InitializeComponent();
        }

        private void TlsSair_Click(object sender, EventArgs e) => Application.Exit();

        private void TlsJogar_Click(object sender, EventArgs e) => Jogo_Load(sender, e);

        private void TslPausa_Click(object sender, EventArgs e)
        {
            if(TslPausa.Text == "Pausa")
            {
                timer1.Stop();
                TslPausa.Text = "Continuar";
            }

            timer1.Start();
            TslPausa.Text = "Pausa";
        }
    }
}
