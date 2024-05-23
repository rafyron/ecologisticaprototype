using System;
using System.Windows.Forms;
using System.IO; // Adicione esta linha para usar a classe File

namespace EcologisticaPrototype
{
    public partial class Form2 : Form
    {
        private string usuarioLogado;

        public Form2(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario; // Inicializa usuarioLogado aqui

            // Controla a visibilidade das opções do menu 
            debugToolStripMenuItem.Visible = usuarioLogado == "ADMIN";
            testesEspeciaisToolStripMenuItem.Visible = usuarioLogado == "ADMIN";
        }

        private void voltarAoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe a caixa de diálogo de confirmação
            DialogResult resultado = MessageBox.Show("Deseja realmente desconectar?", "Confirmação",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Grava o log de desconexão 
                GravarLogDesconexao();

                // Volta para o Form1 (Login)
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide(); // Esconde o Form2 (Home)
            }
            // Se o usuário clicar em "Não", nada acontece
        }

        private void GravarLogDesconexao()
        {
            try
            {
                string nomeArquivoLog = "log_acessos.txt";
                string log = $"Usuário: desconectou. Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";

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

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testesEspeciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}