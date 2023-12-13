namespace projetoAgendamentosSalaWFSenac
{
    partial class Tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_login));
            Btn_login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Btn_Cancela = new Button();
            SuspendLayout();
            // 
            // Btn_login
            // 
            Btn_login.Location = new Point(404, 374);
            Btn_login.Name = "Btn_login";
            Btn_login.Size = new Size(75, 23);
            Btn_login.TabIndex = 0;
            Btn_login.Text = "Login";
            Btn_login.UseVisualStyleBackColor = true;
            Btn_login.Click += Btn_login_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(297, 262);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Digite seu usuário";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(297, 322);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Digite sua senha";
            textBox2.Size = new Size(206, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(295, 304);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.MenuBar;
            label2.Location = new Point(297, 244);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Usuário";
            // 
            // Btn_Cancela
            // 
            Btn_Cancela.Location = new Point(309, 374);
            Btn_Cancela.Name = "Btn_Cancela";
            Btn_Cancela.Size = new Size(75, 23);
            Btn_Cancela.TabIndex = 6;
            Btn_Cancela.Text = "Cancelar";
            Btn_Cancela.UseVisualStyleBackColor = true;
            Btn_Cancela.Click += Btn_Cancela_Click;
            // 
            // Tela_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 495);
            Controls.Add(Btn_Cancela);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Btn_login);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tela_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Salas - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_login;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button Btn_Cancela;

    }
}