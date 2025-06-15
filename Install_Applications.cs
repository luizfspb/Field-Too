using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Field
{
    public partial class Install_Applications : Form
    {
        public Install_Applications()
        {
            InitializeComponent();
        }

        private void ins_java8_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_java8_71.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_office365_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_office365.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }

        }

        private void ins_sisprod_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_sisprod.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_oracle12_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_oracle12_manual.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_oracle11_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_oracle11(cosyma).bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_prm_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_prm_completo.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_gaetest_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_gaetest.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_isaclient_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_forefront(isaclient).bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_karakun1_6_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_karakun1.6.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_karakun_1_8_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_karakun1.8.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_extra_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_extra.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_nedwork_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_nedwork.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_comex_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_comex.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_personal_med_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_personal_med.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_office2016_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_office_2016.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_sv_office_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_smart_view_for_office.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ini_synchro_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_sychro.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_monaco_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Antes faça a instalação via COSYMA, se não funcionou continue!\n\n \n\nVocê quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_monaco.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }


        }


        private void ins_netskope_dt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_netskope_DT.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_oracle19_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_oracle19(cosyma).bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_bpmstar_button_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_bpmstart_1.0.1.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void ins_zgview_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\install_bat\install_zgview.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        
    }
}
