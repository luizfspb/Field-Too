using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Field
{
    public partial class CiscoForm : Form
    {
        public CiscoForm()
        {
            InitializeComponent();
        }

        private void metodo1_button_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\uninstall_bat\uninstall_cisco_anyconnect_1.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void metodo2_button_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\uninstall_bat\uninstall_cisco_anyconnect_2.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void metodo3_button_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\uninstall_bat\uninstall_cisco_anyconnect_3.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void CiscoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
