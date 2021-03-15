using PasswordSaver.JsonWorker.JsonFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver.UI
{
    public partial class ComboFolderForm : Form
    {
        List<FolderDictionary> folders;
        FolderDictionary currentFolder;
        public ComboFolderForm(List<FolderDictionary> folders, FolderDictionary folderDictionary)
        {
            this.folders = folders;
            currentFolder = folderDictionary;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!folders.Exists(o => o.name == textBoxName.Text))
            {
                FolderDictionary folderDictionary;
                if (folders.Exists(o => o.name == comboBox_father.Text))
                {
                    string father = comboBox_father.Text;
                    folderDictionary = new FolderDictionary(textBoxName.Text, father);
                    folders.Find(o=>o.name==father).children.Add(folderDictionary.name);
                }
                else
                {
                    folderDictionary = new FolderDictionary(textBoxName.Text);
                }
                folders.Add(folderDictionary);
            }

        }

        private void ComboFolderForm_Load(object sender, EventArgs e)
        {
            comboBox_father.Text = currentFolder.name;
            comboBox_father.Enabled = false;

        }
    }
}
