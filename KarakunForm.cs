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
    public partial class KarakunForm : Form
    {
        public KarakunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_karakun_jvm_1.bat";


                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_karakun_jvm_2.bat";


                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }
    }
}
