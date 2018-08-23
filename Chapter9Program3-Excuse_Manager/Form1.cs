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

namespace Chapter9Program3_Excuse_Manager
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder;
        private bool formChanged = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastused.Value;
        }
        private void updateForm(bool changed)
        {
            if(!changed)
            {
                this.excuse.Text = currentExcuse.Description;
                this.result.Text = currentExcuse.Results;
                this.lastused.Value = currentExcuse.LastUsed;

                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    FileDateLabel.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
            }
        }
        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                save.Enabled = true;
                Open.Enabled = true;
                Random.Enabled = true;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(excuse.Text) || String.IsNullOrEmpty(result.Text))
            {
                MessageBox.Show("Please specify an excuse and the result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = excuse.Text + ".txt";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                currentExcuse.save(saveFileDialog1.FileName);
                updateForm(false);
                MessageBox.Show("Excuse written");
            }
        }
        private bool checkChanged()
        {
            if(formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }
        private void Open_Click(object sender, EventArgs e)
        {
            if(checkChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Text files (*.txt) | *.txt | All files(*.*) | *.*";
                openFileDialog1.FileName = excuse.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    updateForm(false);
                }
            }
        }
        private void Random_Click(object sender, EventArgs e)
        {
            string[] fileNames = Directory.GetFiles(selectedFolder, "*.txt");
            if(fileNames.Length==0)
            {
                MessageBox.Show("Please specify a folder with excuse files in it", "No excuse files found");
            }
            else
            {
                if (checkChanged())
                {
                    currentExcuse = new Excuse(random, selectedFolder);
                    updateForm(false);
                }
            }
        }

        private void excuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuse.Text;
            updateForm(true);
        }
        private void result_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = result.Text;
            updateForm(true);
        }
        private void lastused_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastused.Value;
            updateForm(true);
        }
    }
}
