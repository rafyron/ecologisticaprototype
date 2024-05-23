using System;
using System.Windows.Forms;
using System.IO; // Para escrever no arquivo de log

namespace EcologisticaPrototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if ((usuario == "ADMIN" && senha == "ADMSNAKE") || (usuario == "USUARIO" && senha == "1234"))
            {
                // Grava o log de acesso
                GravarLogAcesso(usuario);

                // Redireciona para o Form2 (Home) e fecha o Form1 (Login)
                Form2 home = new Form2(usuario);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GravarLogAcesso(string usuario)
        {
            try
            {
                string nomeArquivoLog = "log_acessos.txt";
                string log = $"Usuário: {usuario}, Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

                // Anexa a informação ao arquivo de log
                using (StreamWriter sw = File.AppendText(nomeArquivoLog))
                {
                    sw.WriteLine(log);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar log: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Exibe a caixa de diálogo de confirmação
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar o programa?", "Confirmação",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Fecha o programa completamente
                Application.Exit();
            }
            // Se o usuário clicar em "Não", nada acontece 
        }
    }
}