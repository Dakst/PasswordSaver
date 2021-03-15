using PasswordSaver.JsonWorker;
using PasswordSaver.JsonWorker.JsonFiles;
using PasswordSaver.Logic;
using PasswordSaver.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PasswordSaver
{
    public partial class Main_Form : Form
    {
        ApplicationControl applicationControl = new ApplicationControl(); //Логика
        ComboFolderDictionary comboFolderDictionary = new ComboFolderDictionary();
        List<Button> passwordSavers = new List<Button>(); //Лист Button_Icons (tab_page_icons)
        ProgramData currentProgramData = new ProgramData(); //Выбранное приложение

        public Main_Form()
        {
            InitializeComponent();
        }//Конструктор
        private void Main_Form_Load(object sender, EventArgs e)
        {
            refresh_Tag_panel_ALL();
            refresh_panel_TreeView();
        }//Загрузка формы
        private void Tag_Panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) //del
            {
                deleteApplication();
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {
                Clipboard.SetText(currentProgramData.passwordHash);
                this.WindowState = FormWindowState.Minimized;
            }
            else if (e.KeyCode == Keys.Insert)
            {
                addApplication();
            }
        }//Обработка нажатий клавиш (del, ctrl+c)

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            var text = Search_TextBox.Text;
            var finded = applicationControl.passwordSaver.programs.FindAll(data => data.programName.ToLower().Contains(text.ToLower()));

            if (tabControl_View.SelectedTab == tabPage_Icons)
            {
                flow_panel_Icons.Controls.Clear();
                foreach (var item in finded)
                {
                    flow_panel_Icons.Controls.Add(passwordSavers.Find(btn => btn.Tag == item));
                }
            }
            else if (tabControl_View.SelectedTab == tabPage_DataGridView)
            {
                var ds = new BindingList<ProgramData>();
                foreach (var item in applicationControl.passwordSaver.programs.Where(program => program.programName.ToLower().Contains(text.ToLower())))
                {
                    ds.Add(item);
                }
                dataGridView_ApplicationInfo.DataSource = ds;
            }
        }//Поиск приложений по полю search_Textbox

        private void refresh_Tag_panel_ALL()
        {
            if (tabControl_View.SelectedTab == tabPage_Icons)
            {
                refresh_Tag_panel_Icons();
            }
            else if (tabControl_View.SelectedTab == tabPage_DataGridView)
            {
                refresh_Tag_panel_dataGridView();
            }
        } //Старт/Обновление tagPanel в зависимости от вкладки
        private void refresh_Tag_panel_Icons()
        {
            // Чистим первую panel
            passwordSavers.Clear();
            flow_panel_Icons.Controls.Clear();
            // Чистим первую panel

            foreach (var item in applicationControl.passwordSaver.programs)
            {
                var btn = new DoubleClickButton()
                {
                    Size = new Size(80, 80),
                    Text = item.programName,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = item.iconPath == null
                    ? BackgroundImage = Properties.Resources.defaultIcon
                    : BackgroundImage = Bitmap.FromFile(item.iconPath),
                    Tag = item
                };
                btn.Click += new EventHandler(Btn_Click);
                btn.DoubleClick += new EventHandler(Btn_Double_Click);
                passwordSavers.Add(btn);
                flow_panel_Icons.Controls.Add(btn);
            }
        }//Старт/Обновление информации в TagPage_Icons - 1
        private void refresh_Tag_panel_dataGridView()
        {
            var ds = new BindingList<ProgramData>();
            foreach (var item in applicationControl.passwordSaver.programs)
            {
                ds.Add(item);
            }
            dataGridView_ApplicationInfo.ColumnHeadersDefaultCellStyle.Font =
                new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            dataGridView_ApplicationInfo.ColumnHeadersHeight = 5;
            dataGridView_ApplicationInfo.RowHeadersVisible = false;
            dataGridView_ApplicationInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_ApplicationInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_ApplicationInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ApplicationInfo.DataSource = ds; //Рабочий способ

            dataGridView_ApplicationInfo.SelectionChanged += new EventHandler(DataGridView_ApplicationInfo_SelectionChanged);
        } //Старт/Обновление информации в TagPage_DataGridView - 2
        private void refresh_panel_TreeView()
        {
            treeView_Application.Nodes.Clear();
            foreach (var item in comboFolderDictionary.folderDictionary.FindAll(o => o.father == null))
            {
                TreeNode node = new TreeNode(item.name);
                node.Tag = item;
                node.ContextMenuStrip = contextMenu_Node;
                treeView_Application.Nodes.Add(node);
                TreeContructor(node, item);
            }
        }
        private void TreeContructor(TreeNode treeNode, FolderDictionary branch)
        {
            if (branch.children != null)
            {
                foreach (var item in branch.children)
                {
                    var folderBranch = comboFolderDictionary.folderDictionary.Find(bran => bran.father == branch.name && bran.name==item);
                    TreeNode newNode = new TreeNode(folderBranch.name);
                    newNode.Tag = folderBranch;
                    newNode.ContextMenuStrip = contextMenu_Node;
                    treeNode.Nodes.Add(newNode);
                    TreeContructor(newNode, folderBranch);
                    
                }
            }
        }
        private void DataGridView_ApplicationInfo_SelectionChanged(object sender, EventArgs e)
        {
            var gridView = (DataGridView)sender;
            var mas = gridView.CurrentRow.Tag;
        } //Изменение выбранного элем. DataGridView

        private void addApplication()
        {
            ApplicationSettingForm applicationSetting = new ApplicationSettingForm(applicationControl.passwordSaver);
            applicationSetting.ShowDialog();
            if (applicationSetting.DialogResult == DialogResult.OK)
            {
                applicationControl.WriteJson();
                MessageBox.Show("Добавлена программа " + applicationControl.passwordSaver.programs.Last().programName);
                refresh_Tag_panel_ALL();
            }
        } //Код добавления приложения
        private void changeApplication()
        {
            ApplicationSettingForm applicationSetting = new ApplicationSettingForm(currentProgramData);
            applicationSetting.ShowDialog();
            if (applicationSetting.DialogResult == DialogResult.OK)
            {
                applicationControl.WriteJson();
                refresh_Tag_panel_ALL();
            }
        } //Код изменения приложения
        private void deleteApplication()
        {
            string message = "Удалить \"" + currentProgramData.programName + "\"?";
            string caption = "Удалить элемент";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                applicationControl.passwordSaver.programs.Remove(currentProgramData);
                applicationControl.WriteJson();
                refresh_Tag_panel_ALL();
            }
        } //Код удаления приложения

        #region Выпадающее МЕНЮ ToolStrip
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка обновить в выпадающем меню
        {
            refresh_Tag_panel_Icons();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e) //Кнопка добавить приложение в выпадающем меню
        {
            addApplication();
        }
        private void changeToolStripMenuItem_Click(object sender, EventArgs e) //Отображение формы редактирования ApplicationSettingForm
        {
            changeApplication();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteApplication();
        } //Кнопка удаления
        #endregion
        #region Button_Icons
        private void Btn_Double_Click(object sender, EventArgs e) //Изменение данных приложения
        {
            changeApplication();
        }
        private void Btn_Click(object sender, EventArgs e) //Происходит при одном щелчке на кнопку Icons в panel_Icons
        {
            var btn = (Button)sender;
            currentProgramData = (ProgramData)btn.Tag;
        }
        #endregion
        #region Фишки с элементами формы
        private void panel2_Resize(object sender, EventArgs e)
        {
            label_TreeView.Location = new Point((panel2.Size.Width / 2) - (label_TreeView.Size.Width / 2), 4);
        }
        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            panel2.Size = new Size(190, 360);
        }
        #endregion
        #region Трей и всё что с этим связано
        private void Main_Form_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                TrayIcon.Visible = true;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                TrayIcon.Visible = false;
            }
        }
        #endregion

        private void tabControl_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tab = (TabControl)sender;
            if (tab.SelectedTab == tabPage_DataGridView)
            {
                refresh_Tag_panel_dataGridView();
            }
            else if (tab.SelectedTab == tabPage_Icons)
            {
                refresh_Tag_panel_Icons();
            }
        }//Происходит при выборе вкладки(Icons..)

        private void add_newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderDictionary SelectedNode = new FolderDictionary();
            ComboFolderForm comboDictionary = new ComboFolderForm(comboFolderDictionary.folderDictionary, SelectedNode);
            comboDictionary.ShowDialog();
            if (comboDictionary.DialogResult == DialogResult.OK)
            {
                comboFolderDictionary.WriteJson();
                MessageBox.Show("Добавлен раздел " + comboFolderDictionary.folderDictionary.Last().name);
                refresh_panel_TreeView();
            }
        }

        private void children_toolStripMenu_Click(object sender, EventArgs e)
        {
            FolderDictionary SelectedNode = (FolderDictionary)treeView_Application.SelectedNode.Tag;
            ComboFolderForm comboDictionary = new ComboFolderForm(comboFolderDictionary.folderDictionary, SelectedNode);
            comboDictionary.ShowDialog();
            if (comboDictionary.DialogResult == DialogResult.OK)
            {
                comboFolderDictionary.WriteJson();
                MessageBox.Show("Добавлен раздел " + comboFolderDictionary.folderDictionary.Last().name);
                refresh_panel_TreeView();
            }
        }
    }
}