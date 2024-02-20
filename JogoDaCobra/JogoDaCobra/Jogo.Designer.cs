namespace JogoDaCobra
{
    partial class FormJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            toolStrip1 = new ToolStrip();
            TslJogador = new ToolStripLabel();
            TslNivel = new ToolStripLabel();
            TslPontos = new ToolStripLabel();
            TlsJogar = new ToolStripDropDownButton();
            TlsSair = new ToolStripDropDownButton();
            TslPausa = new ToolStripDropDownButton();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { TslJogador, TslNivel, TslPontos, TlsJogar, TlsSair, TslPausa });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TslJogador
            // 
            TslJogador.Name = "TslJogador";
            TslJogador.Size = new Size(49, 22);
            TslJogador.Text = "Jogador";
            // 
            // TslNivel
            // 
            TslNivel.Name = "TslNivel";
            TslNivel.Size = new Size(34, 22);
            TslNivel.Text = "Nível";
            // 
            // TslPontos
            // 
            TslPontos.Name = "TslPontos";
            TslPontos.Size = new Size(39, 22);
            TslPontos.Text = "Ponto";
            // 
            // TlsJogar
            // 
            TlsJogar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TlsJogar.Image = (Image)resources.GetObject("TlsJogar.Image");
            TlsJogar.ImageTransparentColor = Color.Magenta;
            TlsJogar.Name = "TlsJogar";
            TlsJogar.Size = new Size(48, 22);
            TlsJogar.Text = "Jogar";
            TlsJogar.Click += TlsJogar_Click;
            // 
            // TlsSair
            // 
            TlsSair.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TlsSair.Image = (Image)resources.GetObject("TlsSair.Image");
            TlsSair.ImageTransparentColor = Color.Magenta;
            TlsSair.Name = "TlsSair";
            TlsSair.Size = new Size(39, 22);
            TlsSair.Text = "Sair";
            TlsSair.Click += TlsSair_Click;
            // 
            // TslPausa
            // 
            TslPausa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TslPausa.Image = (Image)resources.GetObject("TslPausa.Image");
            TslPausa.ImageTransparentColor = Color.Magenta;
            TslPausa.Name = "TslPausa";
            TslPausa.Size = new Size(51, 22);
            TslPausa.Text = "Pausa";
            TslPausa.Click += TslPausa_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormJogo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Jogo";
            Load += Jogo_Load;
            Paint += Jogo_Paint;
            KeyDown += Jogo_KeyDown;
            KeyPress += Jogo_KeyPress;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel TslNivel;
        private ToolStripLabel TslPontos;
        private ToolStripDropDownButton TlsJogar;
        private ToolStripDropDownButton TlsSair;
        private ToolStripDropDownButton TslPausa;
        private System.Windows.Forms.Timer timer1;
        private ToolStripLabel TslJogador;
    }
}