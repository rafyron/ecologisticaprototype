namespace EcologisticaPrototype
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnLogin = new Button();
            label6 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            btnSair = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Name = "panel1";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.Name = "txtUsuario";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.DarkGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.caminhao;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            resources.ApplyResources(notifyIcon1, "notifyIcon1");
            // 
            // btnSair
            // 
            resources.ApplyResources(btnSair, "btnSair");
            btnSair.Name = "btnSair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button btnLogin;
        private Label label6;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSair;
    }
}
