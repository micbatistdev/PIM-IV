using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanGreenProject
{
    public partial class RegisterForm3 : Form
    {
        public RegisterForm3()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            RegisterForm2 registerForm = new RegisterForm2();
            registerForm.Show();
            this.Hide();
        }

        private void Btn_continuar_Click(object sender, EventArgs e)
        {
            RegisterForm4 registerForm = new RegisterForm4();
            registerForm.Show();
            this.Hide();
        }
    }
}
