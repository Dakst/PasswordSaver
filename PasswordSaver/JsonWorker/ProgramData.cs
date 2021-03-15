using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PasswordSaver.JsonWorker
{
    public class ProgramData
    {
        public ProgramData()
        {

        }
        public ProgramData(string name, string username, string password)
        {
            this.programName = name;
            this.userName = username;
            this.passwordHash = password;
        }
        public ProgramData(string name, string username, string password, string phone, string typeFolder, string iconPath)
        {
            this.programName = name;
            this.userName = username;
            this.passwordHash = password;
            this.phone = phone;
            this.typeFolder = typeFolder;
            this.iconPath = iconPath;
        }
        [DisplayName("Приложение")]
        public string programName { get; set; }
        [DisplayName("Имя пользователя")]
        public string userName { get; set; }
        [DisplayName("Пароль")]
        public string passwordHash { get; set; }
        [DisplayName("Телефон")]
        public string phone { get; set; }
        [DisplayName("Раздел")]
        public string typeFolder { get; set; } = "Стандартный";
        public bool favorites { get; set; } = false;
        public string iconPath { get; set; } = null;
        [DisplayName("Комментарий")]
        public string comments { get; set; } = null;
    }
}
