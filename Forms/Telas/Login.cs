using Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Usuario Inválido");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha Inválido");
                return;
            }

            if (true)//new UsuarioDao().Login(txtUsuario.Text, txtSenha.Text)
            {
                //MessageBox.Show("sucesos");
                //this.Hide();                
                //MenuPrincipal menu = new MenuPrincipal();
                //menu.Show();
                DialogResult = DialogResult.OK;
            }
            else
            {
                
                MessageBox.Show("Usuário ou Senha Inválido");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
