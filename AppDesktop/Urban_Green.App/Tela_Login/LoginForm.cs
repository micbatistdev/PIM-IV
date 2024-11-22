using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using UrbanGreenProject;
using UrbanGreenProject.Properties;

namespace Tela_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            // Configure o texto do LinkLabel
            linkLabel6.Text = "www.urbangreen.com";
            linkLabel6.Links.Add(0, linkLabel6.Text.Length, "https://stunning-valkyrie-262d36.netlify.app");

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }


        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void CardLogin_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; // Ajuste o raio das bordas arredondadas

            // Criar o caminho para bordas arredondadas
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(CardLogin.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(CardLogin.Width - cornerRadius, CardLogin.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, CardLogin.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Configurar o modo de suavização para bordas mais suaves
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Preencher o fundo com a cor preta semi-transparente
                using (Brush b = new SolidBrush(Color.FromArgb(40, Color.Black)))
                {
                    e.Graphics.FillPath(b, path);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverPasswordForm recoverPasswordForm = new RecoverPasswordForm();
            recoverPasswordForm.Show();
            this.Hide();
        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {

        }

        // Variável para controlar o estado de visibilidade da senha
        bool isPasswordVisible = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura a senha para estar oculta quando o formulário for carregado
            inputPassword.UseSystemPasswordChar = true;

            // Inicializa o ícone como "eye" (mostrar a senha) para a primeira interação
            inputPassword.IconRight = Resources.eye;
        }

        private void inputPassword_iconRightClick(object sender, EventArgs e)
        {
            // Alterna o estado de visibilidade da senha
            isPasswordVisible = !isPasswordVisible;

            // Atualiza o campo TextBox para mostrar ou esconder a senha
            inputPassword.UseSystemPasswordChar = !isPasswordVisible;

            // Alterna entre os ícones "eye" e "hidden" dependendo do estado da senha
            if (isPasswordVisible)
            {
                // Se a senha estiver visível, exibe o ícone "hidden" (ocultar)
                inputPassword.IconRight = Resources.hidden;
            }
            else
            {
                // Se a senha estiver oculta, exibe o ícone "eye" (mostrar)
                inputPassword.IconRight = Resources.eye;
            }
        }

        private void guna2vSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void inputUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LinkRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverPasswordForm recoverPasswordForm = new RecoverPasswordForm();
            recoverPasswordForm.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abre o link no navegador padrão
            string target = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(target))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = target,
                    UseShellExecute = true // Necessário para abrir URLs no .NET Core/Framework mais recente
                });
            }
        }
    }
}