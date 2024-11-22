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
    public partial class RelatoriosForm : Form
    {
        public RelatoriosForm()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm2 = new DashboardForm();
            dashboardForm2.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            CultivoForm cultivoForm = new CultivoForm();
            cultivoForm.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            MonitoramentoForm monitoramentoForm = new MonitoramentoForm();
            monitoramentoForm.Show();
            this.Hide();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            EstoqueForm estoqueForm = new EstoqueForm();
            estoqueForm.Show();
            this.Hide();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            SaudeForm saudeForm = new SaudeForm();
            saudeForm.Show();
            this.Hide();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            ContaForm contaForm = new ContaForm();
            contaForm.Show();
            this.Hide();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            ConfiguracoesForm configuracoesForm = new ConfiguracoesForm();
            configuracoesForm.Show();
            this.Hide();
        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void guna2GradientButton11_Click(object sender, EventArgs e)
        {
            AjudaForm ajudaForm = new AjudaForm();
            ajudaForm.Show();
            this.Hide();
        }
    }
}
