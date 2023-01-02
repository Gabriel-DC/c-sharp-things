using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_things.code.IO
{
    public class Dir
    {
        //LISTAR TODOS OS ARQUIVOS DE UMA PASTA E SUBPASTAS QUE TERMINAM COM .DLL
        public IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            //LISTAR TODOS OS ARQUIVOS DE UMA PASTA E SUBPASTAS
            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
                if (file.EndsWith(".dll"))
                    salesFiles.Add(file);

            return salesFiles;
        }

        //RETORNA O DIRETORIO ATUAL
        public string CurrentDirectory()
        {
            //RETORNA O DIRETORIO ATUAL
            var currentDirectory = Directory.GetCurrentDirectory();
            return currentDirectory;
        }

        //RETORNA DIRETORIO ESPECIAL DOCUMENTOS
        public string MyDocuments()
        {
            //RETORNA DIRETORIO ESPECIAL DOCUMENTOS
            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return myDocuments;
        }
    }
}