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
    public partial class Front : Form
    {
        public Front()
        {
           InitializeComponent();

            // Chame o form de Login antes do form principal
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();

            // Verifique se o login foi bem-sucedido antes de continuar
           // if (loginForm.LoginSucceeded)
          // {
                // Continue com a inicialização normal do programa
         //   }
           // else
           // {
                // Feche o programa se o login falhar
          //      this.Close();
         //  }
                       

        }



        //BUTTON ABOUT
        private void about_Button1_Click(object sender, EventArgs e)
        {
            string message = "Desenvolvido por: Luiz Barreto\n\nColaboradores: \n\nAdriano Godoi \n\nEdi Carlos \n\nHumberto Luis \n\nJefferson Galvão \n\nRoberto Luiz ";
            string title = "Informações";
            MessageBox.Show(message, title);
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.ShowDialog();
        }
        //END BUTTON ABOUT


        //BUTTON BOX TOOLS
        private void Tools_box_Enter(object sender, EventArgs e)
        {

        }

        // BUTTON ADM
        private void adm_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dir = @"C:\temp";
            string batFile = Path.Combine(dir, "criar_adm.bat");

            // Cria o diretório se ele não existir
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Escreve os comandos no arquivo .bat
            File.WriteAllText(batFile, @"
            @echo off
            title Colocar Adiministrator
            set /p ""username=Digite o nome de usuario: ""

            @echo off
            net localgroup Administrators %username% /add

            echo Usuario adicionado como ADM!
            @TIMEOUT /T 3 /NOBREAK > NUL
            ");

            // Executa o arquivo .bat
            Process.Start(batFile);
            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        //BUTTON RECRIAR PERFIL
        private void rec_perfil_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dir = @"C:\temp";
                string batFile = Path.Combine(dir, "recriar_perfil.bat");

                // Cria o diretório se ele não existir
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                // Escreve os comandos no arquivo .bat
                File.WriteAllText(batFile, @"
            @echo ------------------------------------------------------------------------------
            @echo Informe o Usuario.
            @echo ------------------------------------------------------------------------------
            @echo off
            set /p UserAccount=""Digite o nome do usuario: ""
            ren ""C:\Users\%UserAccount%"" ""%UserAccount%.old""
            echo A pasta do usuario %UserAccount% foi renomeada para %UserAccount%.old.
            cls

            @TIMEOUT /T 1 /NOBREAK > NUL

            @echo ------------------------------------------------------------------------------
            @echo Abrindo Regedit.
            @echo ------------------------------------------------------------------------------

            @echo off
            REG ADD HKCU\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit /v LastKey /t REG_SZ /d ""HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\ProfileList"" /f
            START regedit
            @TIMEOUT /T 1 /NOBREAK > NUL
            ");

                // Executa o arquivo .bat
                Process.Start(batFile);
            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        
        
        //BUTTON LIBERAR ESPAÇO
        private void lib_espaco_button_Click(object sender, EventArgs e)
        {
            string batCommands = @"
            @echo off
            del /s /q C:\Windows\ccmcache\*
            timeout 2
            rmdir /s /q C:\Windows\ccmcache\
            timeout 2
            del /s /q C:\temp\*
            timeout 2
            rmdir /s /q C:\temp\
            timeout 2
            del /s /q %temp%\*
    
            timeout 4
            mkdir C:\Temp
            timeout 2
            mkdir C:\Windows\ccmcache
            timeout 2";

            File.WriteAllText(@"C:\windows\liberar_espaço.bat", batCommands);

            Process.Start(@"C:\windows\liberar_espaço.bat");
        }

        //BUTTON IMPRESSORA PAR
        private void imp_PAR_button_Click(object sender, EventArgs e)
        {
            string path = "\\\\localpar";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        //BUTTON IMPRESSORA IMPAR
        private void imp_IMPAR_button_Click(object sender, EventArgs e)
        {
            string path = "\\\\localimpar";
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        //BUTTON ATIVAR WINGET
        private void atv_winget_button_Click(object sender, EventArgs e)
        {
            // Define os comandos PowerShell
            string psCommand = @"
        
            add-appxPackage -path \\53.93.157.81\Field\install_applications\winget\Microsoft.DesktopAppInstaller_8wekyb3d8bbwe.msixbundle
            add-appxPackage -path \\53.93.157.81\Field\install_applications\winget\Microsoft.UI.Xaml.2.7.x64.appx
            add-appxPackage -path \\53.93.157.81\Field\install_applications\winget\Microsoft.VCLibs.x64.14.00.Desktop.appx
            Add-AppxPackage -RegisterByFamilyName -MainPackage Microsoft.DesktopAppInstaller_8wekyb3d8bbwe
            ";

            // Primeira execução do comando
            Process.Start(new ProcessStartInfo("powershell", $"/c {psCommand}"));

            // Segunda execução do comando
            Process.Start(new ProcessStartInfo("powershell", $"/c {psCommand}"));
        }

        private void verificar_erros_Windows_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dir = @"C:\temp";
                string batFile = Path.Combine(dir, "verificar_erros_Windows.bat");

                // Cria o diretório se ele não existir
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                // Escreve os comandos no arquivo .bat
                File.WriteAllText(batFile, @"
            @echo off
            start perfmon /rel
            ");

                // Executa o arquivo .bat
                Process.Start(batFile);
            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }


        private void revo_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\caminho_do_revo\RevoUPort.exe";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void link_epep_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void link_ztv_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://");
        }

        private void link_zgdock_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        private void link_wspdoku_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://");
        }

        // END BUTTON BOX TOOLS


        //BUTTON FORMS
        private void fixes_maqC_button_Click(object sender, EventArgs e)
        {
            // Verifica se os forms Install_Applications e Uninstall estão abertos, se estiverem, fecha
            if (Application.OpenForms.OfType<Install_Applications>().Count() > 0)
                Application.OpenForms.OfType<Install_Applications>().First().Close();
            if (Application.OpenForms.OfType<Uninstall_Applications>().Count() > 0)
                Application.OpenForms.OfType<Uninstall_Applications>().First().Close();

            // Verifica se o form Fixes já está aberto, se não estiver, abre
            if (Application.OpenForms.OfType<Fixes>().Count() == 0)
            {
                Fixes fixesForm = new Fixes();
                fixesForm.Show();
            }

        }

        private void Ins_app_maqC_button_Click(object sender, EventArgs e)
        {

            // Verifica se os forms Fixes e Uninstall_Applications estão abertos, se estiverem, fecha
            if (Application.OpenForms.OfType<Fixes>().Count() > 0)
                Application.OpenForms.OfType<Fixes>().First().Close();
            if (Application.OpenForms.OfType<Uninstall_Applications>().Count() > 0)
                Application.OpenForms.OfType<Uninstall_Applications>().First().Close();

            // Verifica se o form Install_Applications já está aberto, se não estiver, abre
            if (Application.OpenForms.OfType<Install_Applications>().Count() == 0)
            {
                Install_Applications Install_ApplicationsForm = new Install_Applications();
                Install_ApplicationsForm.Show();
            }

        }

        private void Uni_app_maqC_button_Click(object sender, EventArgs e)
        {
            // Verifica se os forms Fixes e Install_Applications estão abertos, se estiverem, fecha
            if (Application.OpenForms.OfType<Fixes>().Count() > 0)
                Application.OpenForms.OfType<Fixes>().First().Close();
            if (Application.OpenForms.OfType<Install_Applications>().Count() > 0)
                Application.OpenForms.OfType<Install_Applications>().First().Close();

            // Verifica se o form Uninstall já está aberto, se não estiver, abre
            if (Application.OpenForms.OfType<Uninstall_Applications>().Count() == 0)
            {
                Uninstall_Applications Uninstall_ApplicationsForm = new Uninstall_Applications();
                Uninstall_ApplicationsForm.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string message = "Em produção";
            string title = "Correções Maquina M";
            MessageBox.Show(message, title);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string message = "Em produção";
            string title = "Instalações Maquina M";
            MessageBox.Show(message, title);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string message = "Em produção";
            string title = "Desinstalações Maquina M";
            MessageBox.Show(message, title);
        }

        private void Solicitar_button_Click(object sender, EventArgs e)
        {
            SolicitarForm solicitarForm = new SolicitarForm();
            solicitarForm.ShowDialog();
        }

        

        

        private void recuperar_bitlocker_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dir = @"C:\temp";
                string batFile = Path.Combine(dir, "recuperar_bitlocker.bat");

                // Cria o diretório se ele não existir
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                // Escreve os comandos no arquivo .bat
                File.WriteAllText(batFile, @"
            @echo off
setlocal
set ""path=\\C:\""
set ""filename=%COMPUTERNAME%-bitlocker-key.txt""
echo.
echo Recuperando a chave de recuperacao do BitLocker...
echo.
manage-bde -protectors -get C: > ""%path%\%filename%""
echo.
echo A chave de recuperacao do BitLocker foi salva no arquivo %filename% no diretorio especificado.
echo.
@TIMEOUT /T 3 /NOBREAK > NUL
endlocal

            ");

                // Executa o arquivo .bat
                Process.Start(batFile);
            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

        private void verificar_erros_button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Você quer continuar com o comando?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string caminhoDoSetup = @"\\53.93.157.81\Field\fixes_bat\verificar_erros_Windows.bat";

                Process.Start(caminhoDoSetup);

            }
            else if (dialogResult == DialogResult.No)
            {
                // Faça algo se o usuário clicar em 'Não'
            }
        }

              // END BUTTON FORMS




    }
}
