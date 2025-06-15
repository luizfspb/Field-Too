using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Field
{
    public partial class LoginForm : Form
    {
        public bool LoginSucceeded { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
            // Configure o caractere de senha para '*'
            textBox2.PasswordChar = '*';

            // Adicione um manipulador de eventos para o evento KeyDown do TextBox da senha
            textBox2.KeyDown += new KeyEventHandler(textBox2_KeyDown);
        }

        private void acessar_button_Click(object sender, EventArgs e)
        {
            // Verifique se o nome de usuário e a senha estão corretos
            if (textBox1.Text == "onsite" && textBox2.Text == "Brasil&2023")
            {
                // Se o login for bem-sucedido, defina a propriedade LoginSucceeded como true
                LoginSucceeded = true;
                this.Close();
            }
            else
            {
                // Se o login falhar, mostre uma mensagem de erro
                MessageBox.Show("Nome de usuário ou senha incorretos");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifique se a tecla pressionada foi a tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Se a tecla Enter foi pressionada, chame a função do botão de acesso
                acessar_button_Click(sender, e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
