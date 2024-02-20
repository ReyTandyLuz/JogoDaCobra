using JogoDaCobra.Entities;
using System.Collections;

namespace JogoDaCobra
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            toolStripLabel1.Text = "c Nicolas Quiroz Serna";
            toolStripLabel2.Text = DateTime.Now.ToLongDateString() + " |";
            toolStripLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            FormLogin login = new();
            login.ShowDialog();

            Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = DateTime.Now.ToLongDateString() + " |";
            toolStripLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonSair_Click(object sender, EventArgs e) => Application.Exit();
    }
}
