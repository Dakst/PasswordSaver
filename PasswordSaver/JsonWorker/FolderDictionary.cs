using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver.JsonWorker.JsonFiles
{
    public class FolderDictionary
    {
        public FolderDictionary()
        {

        }
        public FolderDictionary(string name)
        {
            this.name = name;
        }
        public FolderDictionary(string name, string fatherFolder)
        {
            this.name = name;
            father = fatherFolder;
        }

        public string name { get; set; } = null;
        public string father { get; set; } = null;
        public List<string> children { get; set; } = new List<string>();
    }
}
