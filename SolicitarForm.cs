using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Field
{
    public partial class SolicitarForm : Form
    {
        public SolicitarForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string software = txtSoftware.Text;
            
            string[] lines = { "ID: " + id, "Software: " + software };

            string fileName = id + " - " + software + ".txt";
            string path = Path.Combine(@"\\53.93.157.81\Server Onsite\Server Onsite\2- TECNICOS\LUIZBAR\Field\Solicitacao", fileName);

            try
            {
                File.WriteAllLines(path, lines);
                MessageBox.Show("Relatório salvo com sucesso!");
                this.Close(); // Fecha o formulário após o envio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o relatório: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
