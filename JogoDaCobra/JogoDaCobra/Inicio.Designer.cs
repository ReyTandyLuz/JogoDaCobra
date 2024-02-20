namespace JogoDaCobra
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            Titulo = new Label();
            pictureBox1 = new PictureBox();
            toolStripLogin = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            toolStripLabel3 = new ToolStripLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            buttonJogar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStripLogin.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            resources.ApplyResources(Titulo, "Titulo");
            Titulo.BackColor = Color.Transparent;
            Titulo.FlatStyle = FlatStyle.Flat;
            Titulo.ForeColor = Color.MintCream;
            Titulo.Name = "Titulo";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // toolStripLogin
            // 
            resources.ApplyResources(toolStripLogin, "toolStripLogin");
            toolStripLogin.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2, toolStripLabel3, toolStripProgressBar1 });
            toolStripLogin.Name = "toolStripLogin";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(toolStripLabel2, "toolStripLabel2");
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(toolStripLabel3, "toolStripLabel3");
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // buttonJogar
            // 
            buttonJogar.BackColor = Color.FromArgb(0, 202, 116);
            buttonJogar.FlatAppearance.BorderColor = Color.FromArgb(0, 126, 72);
            buttonJogar.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(buttonJogar, "buttonJogar");
            buttonJogar.ForeColor = Color.White;
            buttonJogar.Name = "buttonJogar";
            buttonJogar.UseVisualStyleBackColor = false;
            buttonJogar.Click += buttonJogar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.FromArgb(202, 0, 86);
            buttonSair.FlatAppearance.BorderColor = Color.FromArgb(126, 0, 54);
            buttonSair.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(buttonSair, "buttonSair");
            buttonSair.ForeColor = Color.Transparent;
            buttonSair.Name = "buttonSair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImage = Properties.Resources._5201293_2663178;
            Controls.Add(buttonSair);
            Controls.Add(buttonJogar);
            Controls.Add(toolStripLogin);
            Controls.Add(pictureBox1);
            Controls.Add(Titulo);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStripLogin.ResumeLayout(false);
            toolStripLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private PictureBox pictureBox1;
        private ToolStrip toolStripLogin;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private Button buttonJogar;
        private ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button buttonSair;
    }
}
