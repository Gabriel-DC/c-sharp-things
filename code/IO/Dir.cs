using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_things.code.IO
{
    public class Dir
    {
        public IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
                if (file.EndsWith(".dll"))
                    salesFiles.Add(file);

            return salesFiles;
        }
    }
}