namespace JogoDaCobra
{
    partial class CrearLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearLogin));
            linkLabelSenha = new LinkLabel();
            textBoxSenha = new TextBox();
            textBoxUsuario = new TextBox();
            Titulo = new Label();
            pictureBox1 = new PictureBox();
            textBoxConfirmarSenha = new TextBox();
            linkLabelConfirmarSenha = new LinkLabel();
            linkLabelLogin = new LinkLabel();
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabelSenha
            // 
            linkLabelSenha.ActiveLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelSenha.AutoSize = true;
            linkLabelSenha.BackColor = Color.Transparent;
            linkLabelSenha.Font = new Font("Comic Sans MS", 12F);
            linkLabelSenha.LinkColor = Color.White;
            linkLabelSenha.Location = new Point(703, 137);
            linkLabelSenha.Name = "linkLabelSenha";
            linkLabelSenha.Size = new Size(71, 23);
            linkLabelSenha.TabIndex = 16;
            linkLabelSenha.TabStop = true;
            linkLabelSenha.Text = "Mostrar";
            linkLabelSenha.VisitedLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelSenha.LinkClicked += linkLabelSenha_LinkClicked;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxSenha.ForeColor = SystemColors.MenuText;
            textBoxSenha.Location = new Point(452, 134);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PlaceholderText = "Senha";
            textBoxSenha.Size = new Size(245, 26);
            textBoxSenha.TabIndex = 13;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxUsuario.ForeColor = SystemColors.MenuText;
            textBoxUsuario.Location = new Point(452, 102);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Utilizador";
            textBoxUsuario.Size = new Size(245, 26);
            textBoxUsuario.TabIndex = 12;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.MintCream;
            Titulo.Location = new Point(401, 0);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(373, 90);
            Titulo.TabIndex = 11;
            Titulo.Text = "Criar conta";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-13, -34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 385);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxConfirmarSenha.ForeColor = SystemColors.MenuText;
            textBoxConfirmarSenha.Location = new Point(452, 166);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.PlaceholderText = "Confirmar senha";
            textBoxConfirmarSenha.Size = new Size(245, 26);
            textBoxConfirmarSenha.TabIndex = 18;
            textBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // linkLabelConfirmarSenha
            // 
            linkLabelConfirmarSenha.ActiveLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelConfirmarSenha.AutoSize = true;
            linkLabelConfirmarSenha.BackColor = Color.Transparent;
            linkLabelConfirmarSenha.Font = new Font("Comic Sans MS", 12F);
            linkLabelConfirmarSenha.LinkColor = Color.White;
            linkLabelConfirmarSenha.Location = new Point(703, 166);
            linkLabelConfirmarSenha.Name = "linkLabelConfirmarSenha";
            linkLabelConfirmarSenha.Size = new Size(71, 23);
            linkLabelConfirmarSenha.TabIndex = 19;
            linkLabelConfirmarSenha.TabStop = true;
            linkLabelConfirmarSenha.Text = "Mostrar";
            linkLabelConfirmarSenha.VisitedLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelConfirmarSenha.LinkClicked += linkLabelConfirmarSenha_LinkClicked;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.ActiveLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.BackColor = Color.Transparent;
            linkLabelLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLogin.LinkColor = Color.White;
            linkLabelLogin.Location = new Point(513, 198);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(117, 23);
            linkLabelLogin.TabIndex = 22;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Já tens conta?";
            linkLabelLogin.VisitedLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelLogin.Click += buttonCancelar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(202, 0, 86);
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(126, 0, 54);
            buttonCancelar.FlatAppearance.BorderSize = 2;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(401, 228);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(189, 55);
            buttonCancelar.TabIndex = 21;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.LimeGreen;
            buttonConfirmar.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonConfirmar.FlatAppearance.BorderSize = 2;
            buttonConfirmar.FlatStyle = FlatStyle.Flat;
            buttonConfirmar.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConfirmar.ForeColor = Color.White;
            buttonConfirmar.Location = new Point(596, 228);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(178, 55);
            buttonConfirmar.TabIndex = 20;
            buttonConfirmar.Text = "Criar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonCriar_Click;
            // 
            // CrearLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._8997783_4054966;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 321);
            Controls.Add(linkLabelLogin);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonConfirmar);
            Controls.Add(linkLabelConfirmarSenha);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(linkLabelSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(Titulo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearLogin";
            Text = "CrearLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabelSenha;
        private TextBox textBoxSenha;
        private TextBox textBoxUsuario;
        private Label Titulo;
        private PictureBox pictureBox1;
        private TextBox textBoxConfirmarSenha;
        private LinkLabel linkLabelConfirmarSenha;
        private LinkLabel linkLabelLogin;
        private Button buttonCancelar;
        private Button buttonConfirmar;
    }
}