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
    public partial class RecoverPasswordForm2 : Form
    {
        public RecoverPasswordForm2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RecoverPasswordForm recoverPasswordForm = new RecoverPasswordForm();
            recoverPasswordForm.Show();
            this.Hide();
        }

        private void button_enviar_Click(object sender, EventArgs e)
        {
            NewPasswordSuccessfullyForm newPasswordSuccessfullyForm = new NewPasswordSuccessfullyForm();
            newPasswordSuccessfullyForm.Show();
            this.Hide();
        }
    }
}
