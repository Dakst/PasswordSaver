using PasswordSaver.JsonWorker.JsonFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver.Logic
{
    public class ComboFolderDictionary
    {
#if DEBUG
        string path = "JsonWorker/JsonFiles/FoldersDictionary.json";
#else
        string path = "JsonWorker/JsonFiles/FoldersDictionary.json";
#endif
        public List<FolderDictionary> folderDictionary = new List<FolderDictionary>();
        public ComboFolderDictionary()
        {
            FileHelper fileHelper = new FileHelper();
            if (fileHelper.FileExistCreate(path))
            {
                WriteJson();
            }
            else
            {
                folderDictionary = ReadJson(path);
            }
        }
        public List<FolderDictionary> ReadJson(string path)
        {
            JsonConverter<List<FolderDictionary>> jsonConverter = new JsonConverter<List<FolderDictionary>>();
            var testJson = jsonConverter.ReadJsonFile(path);
            return testJson;
        }
        public async void WriteJson()
        {
            JsonConverter<List<FolderDictionary>> jsonConverter = new JsonConverter<List<FolderDictionary>>(path);
            await jsonConverter.WriteJsonFile(path, folderDictionary);
        }
    }
}
