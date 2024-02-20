namespace JogoDaCobra
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            Titulo = new Label();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonConfirmar = new Button();
            buttonCancelar = new Button();
            linkLabelSenha = new LinkLabel();
            linkLabelCrearCuenta = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(479, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 277);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.BackColor = Color.Transparent;
            Titulo.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.MintCream;
            Titulo.Location = new Point(12, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(461, 90);
            Titulo.TabIndex = 3;
            Titulo.Text = "Jogo da cobra";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxUsuario.ForeColor = SystemColors.MenuText;
            textBoxUsuario.Location = new Point(116, 120);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Utilizador";
            textBoxUsuario.Size = new Size(245, 26);
            textBoxUsuario.TabIndex = 4;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxSenha.ForeColor = SystemColors.MenuText;
            textBoxSenha.Location = new Point(116, 162);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PlaceholderText = "Senha";
            textBoxSenha.Size = new Size(245, 26);
            textBoxSenha.TabIndex = 5;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.LimeGreen;
            buttonConfirmar.FlatAppearance.BorderColor = Color.DarkGreen;
            buttonConfirmar.FlatAppearance.BorderSize = 2;
            buttonConfirmar.FlatStyle = FlatStyle.Flat;
            buttonConfirmar.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConfirmar.ForeColor = Color.White;
            buttonConfirmar.Location = new Point(248, 221);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(169, 55);
            buttonConfirmar.TabIndex = 6;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(202, 0, 86);
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(126, 0, 54);
            buttonCancelar.FlatAppearance.BorderSize = 2;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(73, 221);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(169, 55);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // linkLabelSenha
            // 
            linkLabelSenha.ActiveLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelSenha.AutoSize = true;
            linkLabelSenha.BackColor = Color.Transparent;
            linkLabelSenha.Font = new Font("Comic Sans MS", 12F);
            linkLabelSenha.LinkColor = Color.White;
            linkLabelSenha.Location = new Point(367, 163);
            linkLabelSenha.Name = "linkLabelSenha";
            linkLabelSenha.Size = new Size(71, 23);
            linkLabelSenha.TabIndex = 8;
            linkLabelSenha.TabStop = true;
            linkLabelSenha.Text = "Mostrar";
            linkLabelSenha.VisitedLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelSenha.LinkClicked += linkLabelSenha_LinkClicked;
            // 
            // linkLabelCrearCuenta
            // 
            linkLabelCrearCuenta.ActiveLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelCrearCuenta.AutoSize = true;
            linkLabelCrearCuenta.BackColor = Color.Transparent;
            linkLabelCrearCuenta.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelCrearCuenta.LinkColor = Color.White;
            linkLabelCrearCuenta.Location = new Point(156, 191);
            linkLabelCrearCuenta.Name = "linkLabelCrearCuenta";
            linkLabelCrearCuenta.Size = new Size(169, 23);
            linkLabelCrearCuenta.TabIndex = 9;
            linkLabelCrearCuenta.TabStop = true;
            linkLabelCrearCuenta.Text = "Ainda não tens conta?";
            linkLabelCrearCuenta.VisitedLinkColor = Color.FromArgb(202, 0, 86);
            linkLabelCrearCuenta.LinkClicked += linkLabelCrearCuenta_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImage = Properties.Resources._5201293_2663178;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(772, 322);
            Controls.Add(linkLabelCrearCuenta);
            Controls.Add(linkLabelSenha);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonConfirmar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(Titulo);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Titulo;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonConfirmar;
        private Button buttonCancelar;
        private LinkLabel linkLabelSenha;
        private LinkLabel linkLabelCrearCuenta;
    }
}