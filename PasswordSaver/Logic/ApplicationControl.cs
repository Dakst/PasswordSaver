using PasswordSaver.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver
{
    public class ApplicationControl
    {
#if DEBUG
        string path = "JsonWorker/JsonFiles/Passwords.json";
#else
        string path = "JsonWorker/JsonFiles/Passwords.json";
#endif
        public CommandList commandList = new CommandList();
        public PasswordSaver passwordSaver = new PasswordSaver();
        public ApplicationControl()
        {
            FileHelper fileHelper = new FileHelper();
            if (fileHelper.FileExistCreate(path))
            {
                WriteJson();
            }
            else
            {
                passwordSaver = ReadJson(path);
            }
        }
        public PasswordSaver getPasswordSaver()
        {
            return passwordSaver;
        }
        public CommandList getCommandList()
        {
            return commandList;
        }

        private PasswordSaver ReadJson(string path)
        {
            JsonConverter<PasswordSaver> jsonConverter = new JsonConverter<PasswordSaver>();
            var testJson = jsonConverter.ReadJsonFile(path);
            return testJson;
        }
        public async void WriteJson(/*string path*/)
        {
            JsonConverter<PasswordSaver> jsonConverter = new JsonConverter<PasswordSaver>(path);
            await jsonConverter.WriteJsonFile(path, passwordSaver);
        }
    }

}
