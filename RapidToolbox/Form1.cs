using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidToolbox
{
    public partial class RapidToolbox : Form
    {
        public RapidToolbox()
        {
            InitializeComponent();
        }

        private void install_btn_Click(object sender, EventArgs e)
        {
            if (vscode_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167206817256968202/VSCodeUserSetup-x64-1.83.1.exe";

                string downloadedFileName = "vscode-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (discord_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167208266422566995/DiscordSetup.exe";

                string downloadedFileName = "discord-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (steam_check.Checked)
            {
                string downloadUrl = "https://download2300.mediafire.com/z3jyw6oqw7ogoCGBAmYcuuizZ6YZjDY4XTWNTkwFEouqoNSxfNWUrLevbIOHGlaCfbCHGvwjn5WWSYNqaab1HNk7Ko7-4LhOtrxJ8n7zCThcuEDVvCy08qK92ghbH47d6ooUNsluVasGyiB53cKyEHiYlLZY58TZoaLDH5HT9wI/za7d7vrav66onpm/SteamSetup.exe";

                string downloadedFileName = "steam-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (battlenet_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167222017146245120/Battle.net-Setup.exe";

                string downloadedFileName = "battlenet-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (epicgames_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167225363622023211/EpicInstaller-15.17.1.msi";

                string downloadedFileName = "epicgames-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (eaplay_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167225828090851408/EAappInstaller.exe";

                string downloadedFileName = "eaplay-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (rockstar_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167227375545757787/Rockstar-Games-Launcher.exe";

                string downloadedFileName = "rockstar-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (bethesda_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167227890098774137/BethesdaNetLauncher_Setup.exe";

                string downloadedFileName = "bethesda-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (cpuz_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167501638462865579/cpu-z_2.08-en.exe";

                string downloadedFileName = "cpuz-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (hwinfo_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167501929895702661/HWiNFO64.exe";

                string downloadedFileName = "hwinfo-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (crystaldi_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167501727445041283/CrystalDiskInfo9_1_1.exe";

                string downloadedFileName = "crystaldi-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (anydesk_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167502249682026617/AnyDesk.exe";

                string downloadedFileName = "anydesk-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (msiab_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167502510043435078/MSIAfterburnerSetup465.exe";

                string downloadedFileName = "msiab-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (rivatuner_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167502561377529876/Guru3D.com-RTSSSetup734.exe";

                string downloadedFileName = "rivatuner-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (audacity_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167502691421929522/audacity-win-3.3.3-x64.exe";

                string downloadedFileName = "audacity-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (qbitt_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167503164824637512/qbittorrent_4.5.5_x64_setup.exe";

                string downloadedFileName = "qbitt-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (occt_check.Checked)
            {
                string downloadUrl = "https://download1529.mediafire.com/ypfoz28ohnugWh2P3gWUEZTa3mKVCjDk9Kg3cjgqyjMgTd3lTsjfmHZQIUGnKqCtg1E4LG_tLhJL8EpistnygiaVf7ayCV06LajQ_mIvSdqZ7dbMdSsAgkNf_rbmkbtJCmzPNVNNy2-x4oFPyUiaOdZs-3Ic3N1YRN2yV3YsYfc/gcfdnqly1bzvh9o/OCCT.exe";

                string downloadedFileName = "occt-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (ixtu_check.Checked)
            {
                string downloadUrl = "https://download1501.mediafire.com/it25ip7ev79g9_jQx2VtWU1WIaNIMs66JgyOVGy7tbDN1-3xJGVnBz1m2DBBY2giabE5APwy6rTNcLUxVsUcE70lpWWsC_lo6ZwxTxBU8nlSQ8fKJXdRbVDhHFm0RuXrGCnl12frm6o7vCMdowTzeLZxcDLO8oz2vm8kZzeUZbY/o4wsqxd7ibe8tfm/XTUSetup_7.13.1.5.exe";

                string downloadedFileName = "ixtu-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (amdrm_check.Checked)
            {
                string downloadUrl = "https://download1583.mediafire.com/hpj7xg9eochg9RyuderhFoEbCyMYv7vxQ_udii0rbTECr5ByLsIcx3j1vX9bLF5DvC1NTqv7jO2AAvCZ-Uj6h83BDL6Fkw0FKCpfGWr7W9ReimeCWvtSy7ut5IuqLWNi4_aCkZeL6TEaCc0yREHHMXfs94mXz3FH-GaFbBAwJ24/qzm4owwqzbq93xo/amd-ryzen-master.exe";

                string downloadedFileName = "amdrm-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (malwarebytes_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167587996430778428/MBSetup.exe";

                string downloadedFileName = "malwarebytes-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (userbench_check.Checked)
            {
                string downloadUrl = "https://cdn.discordapp.com/attachments/1167103674259099789/1167589260908580895/UserBenchmarkInstaller.exe";

                string downloadedFileName = "userbench-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (superpos_check.Checked)
            {
                string downloadUrl = "https://download854.mediafire.com/bchi0i42chpgzIElqFtxi1Eg0x36s423H2y4-c_yMfFD7Zkjl1cLApj8718HPk_ZRYZApcRBzJz2yl-ibUqiTKF5-WqDBe8wIb8vNgnD23y-zXpDbtC2A0HjLeGtkNfZLaN-XyYovuFlmjopyPWSqDuTwwXR4DudA0bmS1RCK9M/ixn1b7ie8ov4610/Unigine_Superposition-1.1.exe";

                string downloadedFileName = "superpos-setup.exe";

                try
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(downloadUrl, downloadedFileName);

                        Process.Start(downloadedFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Rapid-OS/Rapid");
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Rapid-OS/Rapid");
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://dsc.gg/rapidos");
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string newsettingsfile = "https://cdn.discordapp.com/attachments/1167103674259099789/1167104204473639003/settings.json";

                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string discordSettingsPath = Path.Combine(appDataPath, "discord", "settings.json");

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(newsettingsfile, discordSettingsPath);
                }

                MessageBox.Show("Succesful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The settings file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string fileName = "Activation.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string fileName = "Colors.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string fileName = "Date & Time.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string fileName = "Default Apps.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            string fileName = "Language.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            string fileName = "Privacy.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button10_Click(object sender, EventArgs e)
        {
            string fileName = "Region.lnk";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string fileName = "Taskbar.url";
            string projectFolder = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            string resourcesFolder = "Res";

            string filePath = System.IO.Path.Combine(projectFolder, resourcesFolder, fileName);

            Console.WriteLine(filePath);

            if (System.IO.File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else
            {
                MessageBox.Show("Doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void sevenzip_check_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void githubdesktop_check_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void visualstudio_check_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewStartupPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click_4(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click_5(object sender, EventArgs e)
        {

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }   
}
