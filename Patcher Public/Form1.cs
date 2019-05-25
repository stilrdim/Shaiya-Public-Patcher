using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Patcher_Public;
using System.Diagnostics;

namespace Patcher_Public
{
    public partial class Form1 : Form
    {
        successfulPatch sP = new successfulPatch();
        FAQform faq = new FAQform();
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                directoryTextBox.Text = openFileDialog1.FileName;
                string path = directoryTextBox.Text;
                var fileContents = File.ReadAllText(path, Encoding.Default);
                if (path.EndsWith(".sah"))
                {
                    disableSahFX.Enabled = true;
                    enableSahFX.Enabled = true;
                    disableGameFX.Enabled = false;
                    enableGameFX.Enabled = false;
                    bool check2 = fileContents.Contains(".EFT");
                    if (check2)
                    {
                        detectFX.Text = "The selected data.sah has some or all effects enabled.";
                    }
                    else
                    {
                        detectFX.Text = "The selected data.sah has NO effects enabled or is encrypted.";
                    }
                }
                else if (path.EndsWith(".exe"))
                {
                    bool check2 = fileContents.Contains("Full Screen Error!!!");
                    if (check2)
                    {
                        detectFX.Text = "The selected game.exe is NOT encrypted.";
                    }
                    else
                    {
                        detectFX.Text = "The selected game.exe is encrypted.";
                        return;
                    }
                    disableGameFX.Enabled = true;
                    enableGameFX.Enabled = true;
                    disableSahFX.Enabled = false;
                    enableSahFX.Enabled = false;
                }
            }
        }

        private void disableSahFX_Click(object sender, EventArgs e)
        {
            try
            {
                string path = directoryTextBox.Text;
                var fileContents = File.ReadAllText(path, Encoding.Default);
                fileContents = fileContents.Replace(".EFT", ".EFA");
                File.WriteAllText(path, fileContents, Encoding.Default);

                SuccessfulPatchDisabled();
            }
            catch
            {
                FailedPatch();
            }
        }

        private void enableSahFX_Click(object sender, EventArgs e)
        {
            try
            {
                string path = directoryTextBox.Text;
                var fileContents = File.ReadAllText(path, Encoding.Default);
                fileContents = fileContents.Replace(".EFA", ".EFT");
                File.WriteAllText(path, fileContents, Encoding.Default);

                SuccessfulPatchEnabled();
            }
            catch
            {
                FailedPatch();
            }
        }

        private void disableGameFX_Click(object sender, EventArgs e)
        {
            try
            {
                string path = directoryTextBox.Text;
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = 0x15a180; // Disable FX    C2 08 00 90
                    fs.WriteByte(0xC2); fs.WriteByte(0x08); fs.WriteByte(0x00); fs.WriteByte(0x90);
                    fs.Close();

                    SuccessfulPatchDisabled();
                }
            }
            catch
            {
                FailedPatch();
            }
        }


        private void enableGameFX_Click(object sender, EventArgs e)
        {
            try
            {
                string path = directoryTextBox.Text;
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = 0x15a180; // Enable FX    8B 44 24 08
                    fs.WriteByte(0x8B); fs.WriteByte(0x44); fs.WriteByte(0x24); fs.WriteByte(0x08);
                    fs.Close();

                    SuccessfulPatchEnabled();
                }
            }
            catch
            {
                FailedPatch();
            }
        }

        private void successfulPatchLabel_Click(object sender, EventArgs e)
        {
            sP.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            faq.Show();
        }

        private void SuccessfulPatchDisabled()
        {
            successfulPatchLabel.Text = "Effects disabled successfully!";
            successfulPatchLabel.ForeColor = Color.Lime;
            detectFX.Hide();
        }

        private void SuccessfulPatchEnabled()
        {
            successfulPatchLabel.Text = "Effects enabled successfully!";
            successfulPatchLabel.ForeColor = Color.Lime;
            detectFX.Hide();
        }

        private void FailedPatch()
        {
            successfulPatchLabel.Text = "An error has occured, please try again.";
            successfulPatchLabel.ForeColor = Color.Maroon;
        }
    }
}
