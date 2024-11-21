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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton10_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
            RelatoriosForm relatoriosForm = new RelatoriosForm();
            relatoriosForm.Show();
            this.Hide();
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            ContatoForm contaForm = new ContatoForm();
            contaForm.Show();
            this.Hide();
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            ConfiguracoesForm configuracoesForm = new ConfiguracoesForm();
            configuracoesForm.Show();
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
