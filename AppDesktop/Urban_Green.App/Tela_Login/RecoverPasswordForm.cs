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
    public partial class RecoverPasswordForm : Form
    {
        public RecoverPasswordForm()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void button_Gcod_Click(object sender, EventArgs e)
        {
            RecoverPasswordForm2 recoverPasswordForm2 = new RecoverPasswordForm2();
            recoverPasswordForm2.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm2 = new LoginForm();
            loginForm2.Show();
            this.Hide();
        }
    }
}
