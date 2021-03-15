using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordSaver
{
    public class CommandList
    {
        public List<Command> commands = new List<Command>()
        {
            new Command(){ id = 0, command = null },
            new Command(){ id = 1, command = "Список команд"},
            new Command(){ id = 2, command = "Добавить программу" },
            new Command(){ id = 3, command = "Удалить программу" },
            new Command(){ id = 4, command = "Изменить программу" },
            new Command(){ id = 5, command = "Список программ" }
        };
    }
    public class Command
    {
        public int id { get; set; }
        public string command { get; set; }
    }
}
