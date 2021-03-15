using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSaver.Logic
{
    class FileHelper
    {
        public bool FileExistCreate(string path)
        {
            if (!File.Exists(path))
            {
                var directoryPath = path.Remove(path.LastIndexOf('/'));
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
