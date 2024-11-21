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
    public partial class RegisterForm4 : Form
    {
        public RegisterForm4()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RegisterForm3 registerForm3 = new RegisterForm3();
            registerForm3.Show();
            this.Hide();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            RegisterForm5 registerForm5 = new RegisterForm5();
            registerForm5.Show();
            this.Hide();
        }
    }
}
