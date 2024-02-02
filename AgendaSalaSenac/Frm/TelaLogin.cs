using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSalaSenac
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String User = "admin";
            string Password = "admin";

            if (txtUsuario.Text == User & txtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário/Senha Incorretos!");
            }
        }
    }
}
