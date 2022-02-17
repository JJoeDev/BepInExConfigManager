using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BepInExConfigEditor
{
    public partial class Form1 : Form
    {
        
        string configPath;

        public Form1()
        {
            InitializeComponent();
            loadPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConfigFilePath.Text = browser.SelectedPath;
                configPath = browser.SelectedPath;

                savePath();
            }
            else
            {
                ConfigFilePath.Text = "";
            }
        }

        internal void loadPath()
        {
            try
            {
                StreamReader reader = new StreamReader(Application.StartupPath + "\\savedPath\\" + "Saved_path.txt");
                configPath = reader.ReadLine();
                ConfigFilePath.Text = configPath;
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ConfigFilePath.Text = "Please make the first setup by clicking on Browse and finding your steam game. Then find the config folder in the BepInEx folder";
            }
        }

        internal void savePath()
        {
            StreamWriter writer = new StreamWriter(Application.StartupPath + "\\savedPath\\" + "Saved_path.txt");
            writer.WriteLine(configPath);
            writer.Close();
        }

        private void fillListBox(ListBox lbs, string folder, string fileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            FileInfo[] files = dinfo.GetFiles(fileType);
            foreach (FileInfo _file in files)
            {
                lbs.Items.Add(_file.Name);
            }
        }

        private void fillRichTextBox(ListBox lbs)
        {
            TextEditor.Text = File.ReadAllText(configPath + $"\\{lbs.SelectedItem}");
        }

        private void ConfigBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConfigBox.SelectedItems != null)
                fillRichTextBox(ConfigBox);
            else
                return;
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            ConfigBox.Items.Clear();
            fillListBox(ConfigBox, configPath, "*.cfg");
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String savedTxt = TextEditor.Text;
            StreamWriter writer = new StreamWriter(Path.Combine(configPath, $"{ConfigBox.SelectedItem}"));
            writer.Write(savedTxt);
            TextEditor.Text = $"{ConfigBox.SelectedItem} Has now been saved!";
            writer.Close();
        }

        private void CreditBtn_Click(object sender, EventArgs e)
        {
            Form creditsForm = new Credits();
            creditsForm.Show();
        }
    }
}
