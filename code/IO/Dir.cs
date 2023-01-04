using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp_things.code.IO
{
    public class Dir
    {
        #region GetDirectoriesAndFiles

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

        public char DirectorySeparator()
        {
            //RETORNA O SEPARADOR DE DIRETORIO
            var directorySeparator = Path.DirectorySeparatorChar;
            return directorySeparator;
        }

        public char AltDirectorySeparator()
        {
            //RETORNA O SEPARADOR DE DIRETORIO ALTERNATIVO
            var altDirectorySeparator = Path.AltDirectorySeparatorChar;
            return altDirectorySeparator;
        }

        public string CombinePath(string path1, string path2)
        {
            //COMBINA DOIS OU MAIS CAMINHOS
            var combinePath = Path.Combine(path1, path2); // "path1/path2"
            return combinePath;
        }

        public string GetFileName(string path)
        {
            //RETORNA O NOME DO ARQUIVO
            var fileName = Path.GetFileName(path); // "file.txt"
            return fileName;
        }

        public string GetFileNameWithoutExtension(string path)
        {
            //RETORNA O NOME DO ARQUIVO SEM A EXTENSAO
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path); // "file"
            return fileNameWithoutExtension;
        }

        public string GetExtension(string path)
        {
            //RETORNA A EXTENSAO DO ARQUIVO
            var extension = Path.GetExtension(path);
            return extension;
        }

        #endregion GetDirectoriesAndFiles

        #region CreateDirectoriesAndFiles

        public void CreateDirectory(string folderName)
        {
            //CRIA UM DIRETORIO
            Directory.CreateDirectory(Path.Combine(CurrentDirectory(),
            folderName));
        }

        public void CreateFile(string fileName)
        {
            //CRIA UM ARQUIVO
            File.Create(Path.Combine(CurrentDirectory(), fileName));
        }

        public void CreateFileWithContent(string fileName)
        {
            //CRIA UM ARQUIVO E ESCREVE NELE
            File.WriteAllText(Path.Combine(CurrentDirectory(), fileName), "Hello World!");
        }

        #endregion CreateDirectoriesAndFiles

        #region Misc

        public void MoveFile(string sourceFileName, string destFileName)
        {
            //MOVE UM ARQUIVO
            File.Move(sourceFileName, destFileName);
        }

        public void CopyFile(string sourceFileName, string destFileName)
        {
            //COPIA UM ARQUIVO
            File.Copy(sourceFileName, destFileName);
        }

        public void DeleteFile(string fileName)
        {
            //DELETA UM ARQUIVO
            File.Delete(fileName);
        }

        public void DeleteDirectory(string folderName)
        {
            //DELETA UM DIRETORIO
            Directory.Delete(folderName);
        }

        public void DeleteDirectory(string folderName, bool recursive)
        {
            //DELETA UM DIRETORIO
            Directory.Delete(folderName, recursive);
        }

        public bool VerifyDirectoryExists(string folderName)
        {
            //VERIFICA SE UM DIRETORIO EXISTE
            var directoryExists = Directory.Exists(folderName);
            return directoryExists;
        }

        #endregion Misc
    }
}