using PasswordSaver.JsonWorker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver
{
    public partial class ApplicationSettingForm : Form
    {
        ProgramData data;
        PasswordSaver PasswordSaver;
        int Flag = 0;
        string folderIcons = Directory.GetCurrentDirectory() + "\\Icons";
        public ApplicationSettingForm(ProgramData data) //Изменение
        {
            this.data = data;
            Flag = 0;
            InitializeComponent();
        }
        public ApplicationSettingForm(PasswordSaver passwordSaver) //Добавление
        {
            PasswordSaver = passwordSaver;
            Flag = 1;
            InitializeComponent();
        }

        private void ApplicationSettingForm_Load(object sender, EventArgs e)
        {
            if (data != null)
            {
                textBox_Name_Application.Text = data.programName;
                textBox__Username.Text = data.userName;
                textBox__Password.Text = data.passwordHash;
                pictureBox_Icon.ImageLocation = data.iconPath;
                textBox_phone.Text = data.phone;
                comboBox_Folder.Text = data.typeFolder;
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (Flag == 0)
            {
                data.programName = textBox_Name_Application.Text;
                data.userName = textBox__Username.Text;
                data.passwordHash = textBox__Password.Text;
                data.iconPath = pictureBox_Icon.ImageLocation;
                data.phone = textBox_phone.Text;
                data.typeFolder = comboBox_Folder.Text;
            }
            else if (Flag == 1)
            {
                data = new ProgramData();
                data.programName = textBox_Name_Application.Text;
                data.userName = textBox__Username.Text;
                data.passwordHash = textBox__Password.Text;
                data.iconPath = pictureBox_Icon.ImageLocation;
                data.phone = textBox_phone.Text;
                data.typeFolder = comboBox_Folder.Text;
                PasswordSaver.programs.Add(data);
            }
        }

        private void button_Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_Icon_DoubleClick(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "Icons";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    pictureBox_Icon.ImageLocation = filePath;

                    if (!filePath.Contains(folderIcons))
                    {
                        if (!Directory.Exists(folderIcons))
                        {
                            Directory.CreateDirectory(folderIcons);
                        }
                        string nameJpg = filePath.Substring(filePath.LastIndexOf('\\') + 1);
                        string path = folderIcons + "\\" + nameJpg;
                        if (!File.Exists(path))
                        {
                            File.Copy(filePath, path);
                        }
                    }
                }
            }
        }
    }
}
