
namespace PasswordSaver
{
    partial class ApplicationSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSettingForm));
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name_Application = new System.Windows.Forms.TextBox();
            this.label_Name_Application = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox__Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox__Password = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label_Folder = new System.Windows.Forms.Label();
            this.comboBox_Folder = new System.Windows.Forms.ComboBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_Left_Right = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_Left_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Accept
            // 
            this.button_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Accept.Location = new System.Drawing.Point(3, 3);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(210, 44);
            this.button_Accept.TabIndex = 0;
            this.button_Accept.Text = "Применить";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(227, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(210, 44);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cansel_Click);
            // 
            // textBox_Name_Application
            // 
            this.textBox_Name_Application.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Name_Application.Location = new System.Drawing.Point(14, 32);
            this.textBox_Name_Application.Name = "textBox_Name_Application";
            this.textBox_Name_Application.Size = new System.Drawing.Size(198, 26);
            this.textBox_Name_Application.TabIndex = 2;
            // 
            // label_Name_Application
            // 
            this.label_Name_Application.AutoSize = true;
            this.label_Name_Application.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Name_Application.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Name_Application.Location = new System.Drawing.Point(14, 11);
            this.label_Name_Application.Name = "label_Name_Application";
            this.label_Name_Application.Size = new System.Drawing.Size(198, 20);
            this.label_Name_Application.TabIndex = 3;
            this.label_Name_Application.Text = "Название приложения";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Username.Location = new System.Drawing.Point(32, 61);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(166, 20);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "Имя пользователя";
            // 
            // textBox__Username
            // 
            this.textBox__Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox__Username.Location = new System.Drawing.Point(14, 84);
            this.textBox__Username.Name = "textBox__Username";
            this.textBox__Username.Size = new System.Drawing.Size(198, 26);
            this.textBox__Username.TabIndex = 4;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Password.Location = new System.Drawing.Point(73, 113);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(72, 20);
            this.label_Password.TabIndex = 7;
            this.label_Password.Text = "Пароль";
            // 
            // textBox__Password
            // 
            this.textBox__Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox__Password.Location = new System.Drawing.Point(13, 136);
            this.textBox__Password.Name = "textBox__Password";
            this.textBox__Password.Size = new System.Drawing.Size(198, 26);
            this.textBox__Password.TabIndex = 6;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Phone.Location = new System.Drawing.Point(63, 9);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(85, 20);
            this.label_Phone.TabIndex = 9;
            this.label_Phone.Text = "Телефон";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_phone.Location = new System.Drawing.Point(9, 32);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(198, 26);
            this.textBox_phone.TabIndex = 8;
            // 
            // label_Folder
            // 
            this.label_Folder.AutoSize = true;
            this.label_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Folder.Location = new System.Drawing.Point(76, 61);
            this.label_Folder.Name = "label_Folder";
            this.label_Folder.Size = new System.Drawing.Size(71, 20);
            this.label_Folder.TabIndex = 11;
            this.label_Folder.Text = "Раздел";
            // 
            // comboBox_Folder
            // 
            this.comboBox_Folder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_Folder.FormattingEnabled = true;
            this.comboBox_Folder.Location = new System.Drawing.Point(10, 84);
            this.comboBox_Folder.Name = "comboBox_Folder";
            this.comboBox_Folder.Size = new System.Drawing.Size(197, 28);
            this.comboBox_Folder.TabIndex = 12;
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Left.Controls.Add(this.pictureBox_Icon);
            this.panel_Left.Controls.Add(this.label_Name_Application);
            this.panel_Left.Controls.Add(this.label_Password);
            this.panel_Left.Controls.Add(this.textBox_Name_Application);
            this.panel_Left.Controls.Add(this.textBox__Password);
            this.panel_Left.Controls.Add(this.textBox__Username);
            this.panel_Left.Controls.Add(this.label_Username);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.MaximumSize = new System.Drawing.Size(228, 275);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(222, 275);
            this.panel_Left.TabIndex = 13;
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icon.Image")));
            this.pictureBox_Icon.Location = new System.Drawing.Point(61, 172);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Icon.TabIndex = 13;
            this.pictureBox_Icon.TabStop = false;
            this.pictureBox_Icon.DoubleClick += new System.EventHandler(this.pictureBox_Icon_DoubleClick);
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_bottom.Controls.Add(this.button_Accept);
            this.panel_bottom.Controls.Add(this.button_Cancel);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(0, 278);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(441, 51);
            this.panel_bottom.TabIndex = 14;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.comboBox_Folder);
            this.panel_right.Controls.Add(this.textBox_phone);
            this.panel_right.Controls.Add(this.label_Folder);
            this.panel_right.Controls.Add(this.label_Phone);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(222, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(219, 278);
            this.panel_right.TabIndex = 15;
            // 
            // panel_Left_Right
            // 
            this.panel_Left_Right.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_Left_Right.Controls.Add(this.panel_right);
            this.panel_Left_Right.Controls.Add(this.panel_Left);
            this.panel_Left_Right.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Left_Right.Location = new System.Drawing.Point(0, 0);
            this.panel_Left_Right.Name = "panel_Left_Right";
            this.panel_Left_Right.Size = new System.Drawing.Size(441, 278);
            this.panel_Left_Right.TabIndex = 16;
            // 
            // ApplicationSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 329);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_Left_Right);
            this.MaximumSize = new System.Drawing.Size(457, 368);
            this.MinimumSize = new System.Drawing.Size(243, 39);
            this.Name = "ApplicationSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApplicationSettingForm";
            this.Load += new System.EventHandler(this.ApplicationSettingForm_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.panel_Left_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Name_Application;
        private System.Windows.Forms.Label label_Name_Application;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox__Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox__Password;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label_Folder;
        private System.Windows.Forms.ComboBox comboBox_Folder;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_Left_Right;
    }
}