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

namespace Field
{
    public partial class Fixes : Form
    {
        public Fixes()
        {
            InitializeComponent();
        }

        //
        private void Fixes_Load(object sender, EventArgs e)
        {
            
        }
        //


        //BUTTON FIX PRM COSYMA
        private void fix_prm_cosyma_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_prm_cosyma.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        //BUTTON FIX SAP
        private void fix_sap_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_sap.bat";

                ProcessStartInfo startInfo = new ProcessStartInfo(caminhoDoSetup)
                {
                    WindowStyle = ProcessWindowStyle.Minimized
                };

                Process.Start(startInfo);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        //BUTTON FIX SISPROD
        private void fix_sisprod_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_sisprod.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        //BUTTON FIX DNS
        private void fix_dns_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_dns.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        //BUTTON FIX KARAKUN JVM
        private void fix_karakun_button_Click(object sender, EventArgs e)
        {

            KarakunForm Karakunform = new KarakunForm();
            Karakunform.Show();

            
        }

        //BUTTON FIX TEAMS
        private void fix_teams_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_teams.bat";
                

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void fix_prm_manual_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_prm_manual.bat";
                
                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void fix_kb_outlook_2016button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\fix_bk_outlook_2016.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }
    }
}
