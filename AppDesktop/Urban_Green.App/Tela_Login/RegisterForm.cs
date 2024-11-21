using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login;

namespace UrbanGreenProject
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void botao_voltar_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void botao_continuar_Click(object sender, EventArgs e)
        {
            RegisterForm2 loginForm = new RegisterForm2();
            loginForm.Show();
            this.Hide();
        }
    }
}
