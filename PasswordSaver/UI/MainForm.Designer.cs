
namespace PasswordSaver
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TreeView = new System.Windows.Forms.Label();
            this.treeView_Application = new System.Windows.Forms.TreeView();
            this.contextMenu_TreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add_newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl_View = new System.Windows.Forms.TabControl();
            this.tabPage_Icons = new System.Windows.Forms.TabPage();
            this.flow_panel_Icons = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage_DataGridView = new System.Windows.Forms.TabPage();
            this.dataGridView_ApplicationInfo = new System.Windows.Forms.DataGridView();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.contextMenu_Node = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.children_toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenu_TreeView.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl_View.SuspendLayout();
            this.tabPage_Icons.SuspendLayout();
            this.tabPage_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ApplicationInfo)).BeginInit();
            this.contextMenu_Node.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Search_TextBox);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 90);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(663, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск";
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search_TextBox.Location = new System.Drawing.Point(558, 48);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(269, 26);
            this.Search_TextBox.TabIndex = 2;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.addToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton1.Text = "Меню";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.refreshToolStripMenuItem.Text = "Обновить";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label_TreeView);
            this.panel2.Controls.Add(this.treeView_Application);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.MinimumSize = new System.Drawing.Size(65, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 360);
            this.panel2.TabIndex = 4;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // label_TreeView
            // 
            this.label_TreeView.AutoSize = true;
            this.label_TreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TreeView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_TreeView.Location = new System.Drawing.Point(65, 4);
            this.label_TreeView.Name = "label_TreeView";
            this.label_TreeView.Size = new System.Drawing.Size(69, 20);
            this.label_TreeView.TabIndex = 1;
            this.label_TreeView.Text = "Список";
            // 
            // treeView_Application
            // 
            this.treeView_Application.ContextMenuStrip = this.contextMenu_TreeView;
            this.treeView_Application.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView_Application.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.treeView_Application.Location = new System.Drawing.Point(0, 28);
            this.treeView_Application.Name = "treeView_Application";
            this.treeView_Application.Size = new System.Drawing.Size(190, 332);
            this.treeView_Application.TabIndex = 0;
            // 
            // contextMenu_TreeView
            // 
            this.contextMenu_TreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_newToolStripMenuItem});
            this.contextMenu_TreeView.Name = "contextMenu_TreeView";
            this.contextMenu_TreeView.Size = new System.Drawing.Size(127, 26);
            // 
            // add_newToolStripMenuItem
            // 
            this.add_newToolStripMenuItem.Name = "add_newToolStripMenuItem";
            this.add_newToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.add_newToolStripMenuItem.Text = "Добавить";
            this.add_newToolStripMenuItem.Click += new System.EventHandler(this.add_newToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl_View);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(190, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 360);
            this.panel3.TabIndex = 5;
            // 
            // tabControl_View
            // 
            this.tabControl_View.Controls.Add(this.tabPage_Icons);
            this.tabControl_View.Controls.Add(this.tabPage_DataGridView);
            this.tabControl_View.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tabControl_View.Location = new System.Drawing.Point(0, 0);
            this.tabControl_View.Name = "tabControl_View";
            this.tabControl_View.SelectedIndex = 0;
            this.tabControl_View.Size = new System.Drawing.Size(646, 360);
            this.tabControl_View.TabIndex = 0;
            this.tabControl_View.SelectedIndexChanged += new System.EventHandler(this.tabControl_View_SelectedIndexChanged);
            this.tabControl_View.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tag_Panel_KeyDown);
            // 
            // tabPage_Icons
            // 
            this.tabPage_Icons.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage_Icons.Controls.Add(this.flow_panel_Icons);
            this.tabPage_Icons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_Icons.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Icons.Name = "tabPage_Icons";
            this.tabPage_Icons.Size = new System.Drawing.Size(638, 327);
            this.tabPage_Icons.TabIndex = 0;
            this.tabPage_Icons.Text = "Иконки";
            // 
            // flow_panel_Icons
            // 
            this.flow_panel_Icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_panel_Icons.Location = new System.Drawing.Point(0, 0);
            this.flow_panel_Icons.Name = "flow_panel_Icons";
            this.flow_panel_Icons.Size = new System.Drawing.Size(638, 327);
            this.flow_panel_Icons.TabIndex = 0;
            // 
            // tabPage_DataGridView
            // 
            this.tabPage_DataGridView.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_DataGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage_DataGridView.Controls.Add(this.dataGridView_ApplicationInfo);
            this.tabPage_DataGridView.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DataGridView.Name = "tabPage_DataGridView";
            this.tabPage_DataGridView.Size = new System.Drawing.Size(638, 327);
            this.tabPage_DataGridView.TabIndex = 1;
            this.tabPage_DataGridView.Text = "Табличка";
            // 
            // dataGridView_ApplicationInfo
            // 
            this.dataGridView_ApplicationInfo.AllowUserToAddRows = false;
            this.dataGridView_ApplicationInfo.AllowUserToDeleteRows = false;
            this.dataGridView_ApplicationInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_ApplicationInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ApplicationInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ApplicationInfo.Name = "dataGridView_ApplicationInfo";
            this.dataGridView_ApplicationInfo.Size = new System.Drawing.Size(638, 327);
            this.dataGridView_ApplicationInfo.TabIndex = 0;
            // 
            // TrayIcon
            // 
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "TrayIcon";
            this.TrayIcon.Visible = true;
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(190, 90);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 360);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            this.splitter1.DoubleClick += new System.EventHandler(this.splitter1_DoubleClick);
            // 
            // contextMenu_Node
            // 
            this.contextMenu_Node.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.children_toolStripMenu});
            this.contextMenu_Node.Name = "contextMenu_TreeView";
            this.contextMenu_Node.Size = new System.Drawing.Size(181, 48);
            // 
            // children_toolStripMenu
            // 
            this.children_toolStripMenu.Name = "children_toolStripMenu";
            this.children_toolStripMenu.Size = new System.Drawing.Size(180, 22);
            this.children_toolStripMenu.Text = "Добавить";
            this.children_toolStripMenu.Click += new System.EventHandler(this.children_toolStripMenu_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main_Form";
            this.Text = "PasswordSaver";
            this.Deactivate += new System.EventHandler(this.Main_Form_Deactivate);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenu_TreeView.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl_View.ResumeLayout(false);
            this.tabPage_Icons.ResumeLayout(false);
            this.tabPage_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ApplicationInfo)).EndInit();
            this.contextMenu_Node.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Label label_TreeView;
        private System.Windows.Forms.TreeView treeView_Application;
        private System.Windows.Forms.TabControl tabControl_View;
        private System.Windows.Forms.TabPage tabPage_Icons;
        private System.Windows.Forms.FlowLayoutPanel flow_panel_Icons;
        private System.Windows.Forms.TabPage tabPage_DataGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView_ApplicationInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenu_TreeView;
        private System.Windows.Forms.ToolStripMenuItem add_newToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Node;
        private System.Windows.Forms.ToolStripMenuItem children_toolStripMenu;
    }
}

